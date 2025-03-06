using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;

namespace WindowsFormsApp4
{
    public partial class button : Form
    {
        public button()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string readtext = button1.Text;
            string[] twonumbers = readtext.Split('x');
            double a, b, c;
            a = Convert.ToDouble(twonumbers[0]);
            b = Convert.ToDouble(twonumbers[1]);
            c = a * b;
            solution_label.Text = c.ToString();
            solution_textbox.Text = c.ToString();
        }
    }
}
