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
                        using (StreamReader reader = new StreamReader(file))
                        {
                            reader.BaseStream.Seek(0, SeekOrigin.Begin);
                            richTextBox1.Clear();

                            string line = reader.ReadLine();
                            while (line != null)
                            {
                                richTextBox1.Text += line + "\n";
                                line = reader.ReadLine();
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

        private void SaveFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(file))
                        {
                            writer.Flush();
                            writer.BaseStream.Seek(0, SeekOrigin.Begin);
                            writer.Write(richTextBox1.Text);
                            writer.Flush();
                        }
                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show($"Une erreur est survenue: {e.Message}", "Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
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

        private void toolStripButtonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }


    }
}
