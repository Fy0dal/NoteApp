using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Главное окно программы.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранилище заметок.
        /// </summary>
        private Project _notes = new Project();
        private List<Note> _viewedNotes = new List<Note>();

        public MainForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(NoteApp.NoteCategory)));
            CategoryComboBox.Items.Add("All");
            CategoryComboBox.SelectedIndex = CategoryComboBox.Items.Count - 1;
        }

        /// <summary>
        /// Загрузка из файла.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _notes = ProjectManager.LoadFromFile(ProjectManager.PathFile());
            _viewedNotes = _notes.Notes;
            UpdateListBox();
            LastSelectedNote();
            ProjectManager.SaveToFile(_notes, ProjectManager.PathFile());
        }

        /// <summary>
        /// Вывод информации о выбранной заметки. 
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = NoteListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                ClearSelection();
                return;
            }
            var selectedNote = _viewedNotes[selectedIndex];
            _notes.CurrentIndexNote = selectedIndex;
            TitleLabel.Text = selectedNote.Name;
            Categorylabel.Text = selectedNote.Category.ToString();
            CreatedDateTimePicker.Value = selectedNote.CreatedTime;
            ModifiefDateTimePicker.Value = selectedNote.ModifiedTime;
            NoteTextTextBox.Text = selectedNote.Text;
        }

        /// <summary>
        /// Последняя выбранная заметка.
        /// </summary>
        private void LastSelectedNote()
        {
            try
            {
                NoteListBox.SelectedIndex = _notes.CurrentIndexNote;
            }
            catch (Exception)
            {
                ClearSelection();
                return;
            }
        }

        /// <summary>
        /// Обновление списка заметок.
        /// </summary>
        private void UpdateListBox()
        {
            _viewedNotes = _notes.Notes;
            if (CategoryComboBox.SelectedIndex != CategoryComboBox.Items.Count - 1)
            {
                _viewedNotes = _notes.SortByEditing(_viewedNotes, (NoteCategory)CategoryComboBox.SelectedIndex);
            }
            else
            {
                _viewedNotes = _notes.SortByEditing(_viewedNotes);
            }
            NoteListBox.Items.Clear();
            for (int i = 0; i < _viewedNotes.Count; i++)
            {
                NoteListBox.Items.Add(_viewedNotes[i].Name);
            }
        }

        /// <summary>
        /// Добавление новой заметки.
        /// </summary>
        private void AddNote()
        {
            NoteForm addNote = new NoteForm();
            DialogResult dialogResult = addNote.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                _notes.Notes.Add(addNote.Note);
                _viewedNotes.Add(addNote.Note);
                NoteListBox.Items.Add(addNote.Note.Name);
                UpdateListBox();
                if (NoteListBox.Items.Count != 0)
                {
                    NoteListBox.SelectedIndex = 0;
                }
                else
                {
                    ClearSelection();
                }
                ProjectManager.SaveToFile(_notes, ProjectManager.PathFile());
            }
        }

        /// <summary>
        /// Редактирование заметки.
        /// </summary>
        private void EditNote()
        {
            var selectedIndex = NoteListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                var selectedNote = _viewedNotes[selectedIndex];
                var editNote = new NoteForm { Note = selectedNote };
                DialogResult dialogResult = editNote.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    var noteSelectIndex = _notes.Notes.IndexOf(selectedNote);
                    var editedNote = editNote.Note;
                    _viewedNotes.RemoveAt(selectedIndex);
                    _notes.Notes.RemoveAt(noteSelectIndex);
                    _viewedNotes.Insert(selectedIndex, editedNote);
                    _notes.Notes.Insert(noteSelectIndex, editedNote);
                    NoteListBox.Items.Insert(selectedIndex, editedNote.Name);
                }
                _notes.CurrentIndexNote = NoteListBox.SelectedIndex;
                UpdateListBox();
                if (NoteListBox.Items.Count != 0)
                {
                    NoteListBox.SelectedIndex = 0;
                }
                else
                {
                    ClearSelection();
                }
                ProjectManager.SaveToFile(_notes, ProjectManager.PathFile());
            }
        }

        /// <summary>
        /// Удаление заметки.
        /// </summary>
        private void RemoveNote()
        {
            var selectedIndex = NoteListBox.SelectedIndex;
            if(selectedIndex == -1)
            {
                MessageBox.Show(@"Note not selected!", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var selectedNote = _viewedNotes[selectedIndex];
                DialogResult dialogResult = MessageBox.Show("Do you really want to remove this note: " 
                + _notes.Notes[NoteListBox.SelectedIndex].Name + "?",
                "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    var notesSelectedIndex = _notes.Notes.IndexOf(selectedNote);
                    _notes.Notes.RemoveAt(notesSelectedIndex);
                    _viewedNotes.RemoveAt(selectedIndex);
                    NoteListBox.Items.RemoveAt(selectedIndex);
                }
                UpdateListBox();
                if (NoteListBox.Items.Count != 0)
                {
                    NoteListBox.SelectedIndex = 0;
                }
                else
                {
                    ClearSelection();
                }
                ProjectManager.SaveToFile(_notes, ProjectManager.PathFile());
            }
        }

        /// <summary>
        /// Очищение полей, после удаления выбранной заметки.
        /// </summary>
        private void ClearSelection()
        {
            TitleLabel.Text = "";
            Categorylabel.Text = "";
            CreatedDateTimePicker.Value = DateTime.Now;
            ModifiefDateTimePicker.Value = DateTime.Now;
            NoteTextTextBox.Text = "";
        }

        /// <summary>
        /// Вызов окна About.
        /// </summary>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Добавление новой заметки по нажатию на add.
        /// </summary>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Редактирование заметки по нажатию на edit.
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Удаление заметки по нажатию нa remove.
        /// </summary>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Сохранение в файл при закрытии главного окна.
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(_notes, ProjectManager.PathFile());
        }

        /// <summary>
        /// Обновление списка заметок.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }
       
        /// <summary>
        /// Добавление новой заметки через меню.
        /// </summary>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }
        
        /// <summary>
        /// Редактирование заметки через меню.
        /// </summary>
        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditNote();
        }
        
        /// <summary>
        /// Удаление заметки через меню.
        /// </summary>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }
       
        /// <summary>
        /// Закрытие главного окна через меню.
        /// </summary>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
