using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 消消乐
{
    public partial class 窗体 : Form
    {
        public 窗体()
        {
            //初始化窗口基本信息
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 窗体_Load_1(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = btn.Text;
            }
            else
            {
                label1.Text += btn.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            label1.Text += btn.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(label1.Text == "0")
            {
                label1.Text = "error";
            }
            else
            {
                label1.Text += "/";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            float number1 = 0;
            float number2 = 0;
            string number_word = "";
            char symbol = ' ';
            float sum_number = 0;
            for (int i = 0; i < label1.Text.Length; i++) //分数字
            {
                if (label1.Text[i] == '+' || label1.Text[i] == '-' || label1.Text[i] == '*' || label1.Text[i] == '/')
                {
                    symbol = label1.Text[i];
                    number1 = float.Parse(number_word);
                    number_word = "";
                }
                else
                {
                    number_word += label1.Text[i];
                }
            }
            number2 = float.Parse(number_word);
            if (symbol == '+')
            {
                sum_number = number1 + number2;
                label1.Text += "=" + sum_number.ToString();
            }
            else if (symbol == '-')
            {
                sum_number = number1 - number2;
                label1.Text += "=" + sum_number.ToString();
            }
            else if (symbol == '*')
            {
                sum_number = number1 * number2;
                label1.Text += "=" + sum_number.ToString();
            }
            else if(symbol == '/') 
            {
                sum_number = number1 / number2;
                label1.Text += "=" + sum_number.ToString();
            }
            else
            {
                label1.Text += "=" + label1.Text;
            }
        }

    }
}
