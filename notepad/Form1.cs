using System;
using System.IO;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Pastikan Form1.Designer.cs memuat komponen dengan benar
        }

        private void NewNote(object sender, EventArgs e)
        {
            if (textBox != null)
            {
                textBox.Clear();
            }
        }

        private void SaveNote(object sender, EventArgs e)
        {
            if (textBox != null)
            {
                string path = "notes.txt";
                File.AppendAllText(path, textBox.Text + "\n---\n");
                MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ViewNotes(object sender, EventArgs e)
        {
            string path = "notes.txt";
            if (File.Exists(path))
            {
                if (textBox != null)
                {
                    textBox.Text = File.ReadAllText(path);
                }
            }
            else
            {
                MessageBox.Show("No saved notes found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
