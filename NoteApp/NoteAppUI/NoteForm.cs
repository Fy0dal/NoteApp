using System;
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
    /// Класс формы, для добавления/изменения заметки
    /// </summary>
    public partial class NoteForm : Form
        {
        /// <summary>
        /// Поле  текущей заметки
        /// </summary>
        public Note CurrentNote { get; set; } 

        /// <summary>
        /// Констуктор формы
        /// </summary>
        public NoteForm()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(NoteCategory)).Cast<object>().ToArray();
            CategoryComboBox.Items.AddRange(categories);
        }

        /// <summary>
        /// Нажатие кнопки "Ок"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {          
            try
            {
                if (CategoryComboBox.SelectedIndex != -1)
                {
                    var currentCategory = (NoteCategory)CategoryComboBox.SelectedIndex;
                    CurrentNote = new Note(nameTextBox.Text, noteTextTextBox.Text, currentCategory);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Не выбрана категория заметки!");
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// Метод, для заполнения элементов информацией о текущей заметке
        /// </summary>
        private void ShowNoteInfo()
        {
            nameTextBox.Text = CurrentNote.Name;
            noteTextTextBox.Text = CurrentNote.Text;
            CategoryComboBox.Text = CurrentNote.Category.ToString();
            CreatedDateTimePicker.Value = CurrentNote.CreatedTime;
            ModifiedDateTimePicker.Value = CurrentNote.ModifiedTime;
        }

        /// <summary>
        /// Метод загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_EditForm_Load(object sender, EventArgs e)
        {
            if (CurrentNote != null)
            {
                ShowNoteInfo();
            }
        }

        /// <summary>
        /// Кнопка "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Метод, для изменения цвета titleTextBox, если длина текста больше 50
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
    }
}
