using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace words_in_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            words.Text = "Words: " + Regex.Matches(richTextBox1.Text, @"[\S]+").Count;
            space.Text = "Space: " + Regex.Matches(richTextBox1.Text, @" ").Count;
            new_line.Text = "New line: " + Regex.Matches(richTextBox1.Text, @"\n").Count;
            leters.Text = "Leters: " + Regex.Matches(richTextBox1.Text, @"[\S]").Count;
        }
    }
}
