using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Random random = new Random();
        private int numb;
        private int attemps = 0;
        public Form2()
        {
            InitializeComponent();
            numb = random.Next(1, 101);
            label1.Text = "Попытки : 0";
            label2.Text = "Подсказки : ";
            label3.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int enter))
            {
                label2.Text = "Подсказки : Введите целое число!";
                return;
            }
            attemps++;

            if (enter > numb)
            {
                label2.Text = "Подсказки : меньше";
            }
            else if (enter < numb)
            {
                label2.Text = "Подсказки : больше";
            }
            else
            {
                label2.Text = "Подсказки : правильно";
                label3.Text = "Вы угадали!!!";
            }
            label1.Text = $"Попытки : {attemps}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numb = random.Next(1, 101);
            attemps = 0;
            textBox1.Clear();
            label1.Text = "Попытки : 0";
            label2.Text = "Подсказки : ";
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
