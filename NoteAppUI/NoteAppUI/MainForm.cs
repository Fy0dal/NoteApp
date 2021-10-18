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
        Project notes = new Project();
        Project notes1 = new Project();
        public MainForm()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Note note1 = new Note(textBox1.Text, textBox2.Text, (NoteCategory)Convert.ToInt32(textBox3.Text));
            
            notes.Notes.Add(note1);
            label1.Text = note1.Name + " || " + note1.NoteText + " || " + note1.Category + " || " + note1.DateofCreation + " ||  " + note1.DateOfLastEdit;

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
            ProjectManager.SaveToFile(notes, @"D:\Reposit\json.txt");
        }
        /// <summary>
        /// Загрузка из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            notes1 = ProjectManager.LoadFromFile(@"D:\Reposit\json.txt");
            foreach (Note i in notes1.Notes)
            {
                label2.Text = i.Name + " || " + i.NoteText + " || " + i.Category + " || " + i.DateofCreation + " || " + i.DateOfLastEdit;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
