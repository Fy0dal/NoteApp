using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    /// <summary>
    /// Класс формы "About"
    /// </summary>
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            var url = linkLabel1.Text; 
            System.Diagnostics.Process.Start("chrome.exe", url);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = linkLabel2.Text;
            System.Diagnostics.Process.Start("chrome.exe", url);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
