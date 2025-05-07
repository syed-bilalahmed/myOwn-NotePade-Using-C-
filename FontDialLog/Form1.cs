using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDialLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "NotePad";
            this.Icon = new Icon(@"C:\Users\syedb\Downloads\notepad.ico");


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if (f.ShowDialog() == DialogResult.OK)
                textBox1.Font = f.Font;
        }

        private void FontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ColorDialog colorDialog = new ColorDialog();
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                   
                   textBox1.ForeColor = colorDialog.Color;
                }
            }
        }

        private void OpenNewFileCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
                textBox1.Text = System.IO.File.ReadAllText(op.FileName);

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            if (s.ShowDialog() == DialogResult.OK)
                System.IO.File.WriteAllText(s.FileName,textBox1.Text );

        }
    }
}
