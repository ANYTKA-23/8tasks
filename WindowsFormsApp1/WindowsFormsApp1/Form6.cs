using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = @"        /\__/\";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = @"     =(  ° ^ ° )=";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = @"(´(   /          \";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = @" \_\|__\,,|,,/_|";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
