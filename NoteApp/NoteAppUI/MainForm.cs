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
    //comment
    public partial class MainForm : Form
    {
        /// <summary>
        /// Созданеи обьекта класса
        /// </summary>
        Project notes = new Project();
        Project notes1 = new Project();
        public MainForm()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Прописан вывод в лейбл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            Note note1 = new Note(textBox1.Text, textBox2.Text,
            (NoteCategory)Convert.ToInt32(textBox3.Text));
            
            notes.Notes.Add(note1);
            label1.Text = note1.Name + " || " + note1.Text + " || " + note1.Category 
             + " || " + note1.TimeWhenCreated + " ||  " + note1.TimeWhenChanged;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

      
        /// <summary>
        /// Сохранение в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(notes);
        }
        /// <summary>
        /// Загрузка из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            notes1 = ProjectManager.LoadFromFile();
            foreach (Note i in notes1.Notes)
            {
                label2.Text = i.Name + " || " + i.Text + " || " + i.Category 
                + " || " + i.TimeWhenCreated + " || " + i.TimeWhenChanged;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
