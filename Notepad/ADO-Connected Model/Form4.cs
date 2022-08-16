using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Connected_Model
{
    public partial class Form4 : Form
    {
        string path;
        public Form4()
        {
            InitializeComponent();
        }

        private void saveASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName+".rtf");
                MessageBox.Show("Saved Successfully");
                richTextBox1.Clear();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
                path=openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(path!=null)
            { 
                richTextBox1.SaveFile(path);
                MessageBox.Show("Done");
                path=null;
            }
            else
            {
                saveAsToolStripMenuItem_Click_1(sender,e);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            path=null;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                if (richTextBox1.SelectedText != "")
                    richTextBox1.SelectionFont = fontDialog1.Font;
                else
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                if(richTextBox1.SelectedText !="")
                    richTextBox1.SelectionColor = colorDialog1.Color;
                else
                    richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
