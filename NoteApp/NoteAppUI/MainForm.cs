using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Класс основной формы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле, содержащее список заметок
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Поле, которое содержит индекс заметки
        /// </summary>
        public int CurrentNoteIndex { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>        
        public MainForm()
        {
            InitializeComponent();
            Project = ProjectManager.LoadFromFile();
            UpdateListBox();
        }

        /// <summary>
        /// Метод, который обновляет список заметок в листбоксе
        /// </summary>
        private void UpdateListBox()
        {
            NotesListBox.Items.Clear();
            for (int i = 0; i < Project.Notes.Count; i++)
            {
                NotesListBox.Items.Add(Project.Notes[i].Name);
            }
        }

        /// <summary>
        /// Метод, для отображения информации заметки
        /// </summary>
        private void ShowNoteInfo()
        {
            var note = Project.Notes[CurrentNoteIndex];
            TitleLabel.Text = note.Name;
            notesTextBox.Text = note.Text;
            CreatedDateTimePicker.Value = note.CreatedTime;
            ModifiedDateTimePicker.Value = note.ModifiedTime;
            CategoryLabel.Text = note.Category.ToString();
        }

        /// <summary>
        /// Событие, для установки значения индекса заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentNoteIndex = NotesListBox.SelectedIndex;
            if (CurrentNoteIndex == -1)
            {
                return;
            }
            ShowNoteInfo();
        }

        /// <summary>
        /// Метод, для добавления заметки
        /// </summary>
        private void AddNote()
        {
            NoteForm form = new NoteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Project.Notes.Add(form.CurrentNote);
                ProjectManager.SaveToFile(Project);
                UpdateListBox();
                NotesListBox.SelectedIndex = NotesListBox.Items.Count - 1;
            }
        }
        /// <summary>
        /// Кнопка добавить в верхней панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        /// <summary>
        /// Метод, для редактирования заметки
        /// </summary>
        private void EditNote()
        {
            if (NotesListBox.SelectedIndex != -1)
            {
                NoteForm form = new NoteForm();
                form.CurrentNote = Project.Notes[CurrentNoteIndex];

                if (form.ShowDialog() == DialogResult.OK)
                {
                    Project.Notes[CurrentNoteIndex].Name = form.CurrentNote.Name;
                    Project.Notes[CurrentNoteIndex].Text = form.CurrentNote.Text;
                    Project.Notes[CurrentNoteIndex].Category = form.CurrentNote.Category;
                    Project.Notes[CurrentNoteIndex].ModifiedTime = form.CurrentNote.ModifiedTime;
                    ProjectManager.SaveToFile(Project);
                    UpdateListBox();
                    ShowNoteInfo();
                    NotesListBox.SelectedIndex = CurrentNoteIndex;
                }
            }
            else
            {
                MessageBox.Show("Не выбрана заметка!");
            }
        }

        /// <summary>
        /// Кнопка изменить в верхней панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        /// <summary>
        /// Открытие формы About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        /// <summary>
        /// Метод для удаления заметки
        /// </summary>
        private void RemoveNote()
        {
            if (NotesListBox.SelectedIndex != -1)
            {

                DialogResult result = MessageBox.Show("Do you want to remove this note: " + Project.Notes[CurrentNoteIndex].Name + "", "Remove Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    Project.Notes.Remove(Project.Notes[CurrentNoteIndex]);
                    ProjectManager.SaveToFile(Project);
                    UpdateListBox();
                    NotesListBox.SelectedIndex = 0;
                }

                if (result == DialogResult.Cancel)
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                MessageBox.Show("Не выбрана заметка!");
            }
        }
        /// <summary>
        /// Кнопка изменить в верхней панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(Project);
        }

        /// <summary>
        /// Закрытие формы, через кнопку на тулстрипе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(Project);
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }
    }
}
