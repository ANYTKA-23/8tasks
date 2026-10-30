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
    public partial class Form9 : Form
    {
        public string operation;
        public Form9()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation = textBox2.Text;

            if (int.TryParse(textBox1.Text, out int num1) &&
                int.TryParse(textBox3.Text, out int num2))
            {
                double result = 0;

                // Выполняем операцию
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            MessageBox.Show("Деление на ноль!");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Неизвестная операция!");
                        return;
                }

                // Выводим результат в textBox3
                textBox4.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные числа!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
