using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace smallesttexteditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            string path = "tempfile" + dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + dt.Millisecond.ToString() + ".txt";
            Text = path;
            File.WriteAllText(path, richTextBox1.Text);
        }
    }
}
