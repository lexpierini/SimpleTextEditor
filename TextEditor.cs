using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        //***** Methods *****//
        private void NewFile()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void OpenFile()
        {            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(file))
                        {
                            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                            richTextBox1.Clear();

                            string line = streamReader.ReadLine();
                            while (line != null)
                            {
                                richTextBox1.Text += line + "\n";
                                line = streamReader.ReadLine();
                            }
                        }
                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show($"Une erreur est survenue: {e.Message}", "Erreur de lecture", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }


        //***** MenuStrip methods *****//
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }


        //***** ToolStrip methods *****//
        private void toolStripButtonNewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void toolStripButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}
