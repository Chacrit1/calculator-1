using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double num1 = 0.0;
        double num2 = 0.0;
        string operatorList = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "0";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "2";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input.Text = "0";
            input2.Text= "";
            operatorList = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(input.Text);
            operatorList = "+";
            input2.Text = input.Text + operatorList;
            input.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "6";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "1";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "3";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input.Text = input.Text + ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "4";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "5";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "7";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "8";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (input.Text == "0")
            {
                input.Text = string.Empty;
            }
            input.Text = this.input.Text + "9";
            input.Text = String.Format("{0:#,##0.############}", double.Parse(input.Text));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(input.Text);
            operatorList = "-";
            input2.Text = input.Text + operatorList;
            input.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(input.Text);
            operatorList = "*";
            input2.Text = input.Text + operatorList;
            input.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(input.Text);
            operatorList = "/";
            input2.Text = input.Text + operatorList;
            input.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(input.Text);
            if (operatorList == "+")
            {
                input2.Text = num1.ToString() + operatorList + num2.ToString() + "=";
                input.Text = (num1+num2).ToString();
            }
            if (operatorList == "-")
            {
                input2.Text = num1.ToString() + operatorList + num2.ToString() + "=";

                input.Text = (num1 - num2).ToString();
            }
            if (operatorList == "*")
            {
                input2.Text = num1.ToString() + operatorList + num2.ToString() + "=";

                input.Text = (num1 * num2).ToString();
            }
            if (operatorList == "/")
            {
                input2.Text = num1.ToString() + operatorList + num2.ToString() + "=";

                input.Text = (num1 / num2).ToString();
            }
        }
    }
}
