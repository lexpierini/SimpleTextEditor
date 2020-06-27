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
        StringReader reading = null; // Used in printing methods.

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

        private void PrintText()
        {
            string text = richTextBox1.Text;

            using (reading = new StringReader(text))
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float totalLine = 0;
            float positionY = 0;
            int counter = 0;
            float leftMargin = e.MarginBounds.Left - 50;
            float topMargin = e.MarginBounds.Top - 50;

            if (leftMargin < 5)
            {
                leftMargin = 20;
            }
            if (topMargin < 5)
            {
                topMargin = 20;
            }

            Font font = richTextBox1.Font;
            SolidBrush brush = new SolidBrush(Color.Black);
            totalLine = e.MarginBounds.Height / font.GetHeight(e.Graphics);
            string line = reading.ReadLine();

            while (counter < totalLine)
            {
                positionY = topMargin + (counter * font.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, font, brush, topMargin, positionY, new StringFormat());
                counter++;
                line = reading.ReadLine();

                if (line != null)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }

                brush.Dispose();
            }
        }

        private void CropSelection()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void CopySelection()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void PasteSelection()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Paste();
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

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintText();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment sortir?", "Fermer", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void couToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CropSelection();
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopySelection();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteSelection();
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

        private void toolStripButtonPrintFile_Click(object sender, EventArgs e)
        {
            PrintText();
        }

        private void toolStripButtonCropText_Click(object sender, EventArgs e)
        {
            CropSelection();
        }

        private void toolStripButtonCopyText_Click(object sender, EventArgs e)
        {
            CopySelection();
        }

        private void toolStripButtonPasteText_Click(object sender, EventArgs e)
        {
            PasteSelection();
        }
    }
}
