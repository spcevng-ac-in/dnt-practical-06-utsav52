using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practical6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string op;
        int number1;


        private void one_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "1";
            }
            else
            {
                display.Text += "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "2";
            }
            else
            {
                display.Text += "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "3";
            }
            else
            {
                display.Text += "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "4";
            }
            else
            {
                display.Text += "4";
            }

        }

        private void five_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "5";
            }
            else
            {
                display.Text += "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "6";
            }
            else
            {
                display.Text += "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "7";
            }
            else
            {
                display.Text += "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "8";
            }
            else
            {
                display.Text += "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "9";
            }
            else
            {
                display.Text += "9";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = " ";

        }

        private void add_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(display.Text);
            display.Text = "0";
            op = "+";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(display.Text);
            display.Text = "0";
            op = "-";

        }

        private void mul_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(display.Text);
            display.Text = "0";
            op = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(display.Text);
            display.Text = "0";
            op = "/";
        }

        private void equalsto_Click(object sender, EventArgs e)
        {
            int number2;
            int answer;
            number2 = Convert.ToInt32(display.Text);
            if (op == "+")
            {
                answer = number1 + number2;
                display.Text = Convert.ToString(answer);
                number1 = answer;
            }
            if (op == "-")
            {
                answer = number1 - number2;
                display.Text = Convert.ToString(answer);
                number1 = answer;
            }
            if (op == "*")
            {
                answer = number1 * number2;
                display.Text = Convert.ToString(answer);
                number1 = answer;
            }
            if (op == "/")
            {
                answer = number1 / number2;
                display.Text = Convert.ToString(answer);
                number1 = answer;
            }

        }

        private void zero_Click(object sender, EventArgs e)
        {

            display.Text += "0";
        }
    }
}