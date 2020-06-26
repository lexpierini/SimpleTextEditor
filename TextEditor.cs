using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        //***** MenuStrip methods *****//
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }


        //***** ToolStrip methods *****//
        private void toolStripButtonNewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }
    }
}
