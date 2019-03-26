using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if(opn.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(opn.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = opn.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sav = new SaveFileDialog();
            sav.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sav.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(sav.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sav.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fon = new FontDialog();
            fon.Font = richTextBox1.SelectionFont;
            if(fon.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fon.Font;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            if(col.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = col.Color;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0.2\nCreated by Ishan Shah on 11th February 2019.");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
