using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadApp
{
    public partial class MainNotepadFrm : Form
    {
        public MainNotepadFrm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clickhereForHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MainTextBox.Clear();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MainTextBox.Text.Length > 0)
            {
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                boldToolStripMenuItem.Enabled = true;
                italicToolStripMenuItem.Enabled = true;
                underlineToolStripMenuItem.Enabled = true;
                
            }
            else
            {
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
                boldToolStripMenuItem.Enabled = false;
                italicToolStripMenuItem.Enabled = false;
                underlineToolStripMenuItem.Enabled = false;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Cut();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MainTextBox.Text += DateTime.Now);


            
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.SelectionFont = new Font(MainTextBox.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.SelectionFont = new Font(MainTextBox.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextBox.SelectionFont = new Font(MainTextBox.Font, FontStyle.Underline);
        }
    }
}
