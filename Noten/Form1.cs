using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Noten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|Lua File(*.lua)|*.lua|С file (*.c)|*.c|Other C File(*.h)|*.h|C++ File(*.cpp)|*.cpp";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.Cancel) 
            {
                return;
            }
            string fileNameX = saveFileDialog1.FileName;
            File.WriteAllText(fileNameX, richTextBox.Text);
            MessageBox.Show("Saved!");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filemame = openFileDialog1.FileName;
            string filetext = File.ReadAllText(filemame);
            richTextBox.Text = filetext;
            MessageBox.Show("Opened!");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox.TextLength > 0)
            {
                richTextBox.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.TextLength > 0)
            {
                richTextBox.Paste();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.TextLength > 0)
            {
                richTextBox.Cut();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.White;
            richTextBox.BackColor = Color.White;
            richTextBox.ForeColor = Color.Black;
            richTextBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Gray;
            richTextBox.BackColor = Color.FromArgb(64, 64, 64);
            richTextBox.ForeColor = Color.White;
            richTextBox.BorderStyle= BorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileNameX = saveFileDialog1.FileName;
            File.WriteAllText(fileNameX, richTextBox.Text);
        }
    }
}
