using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romeinse_rekenmachine
{
    public partial class Form1 : Form
    {
        decimal inputOne;
        string arth_operator;

        public Form1()
        {
            InitializeComponent();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = "500";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "10";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "11";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "12";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "13";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "14";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "15";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "16";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "17";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "18";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "19";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "20";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "30";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "40";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "50";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "60";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "70";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "80";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "90";
        }
        
        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = "100";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = "200";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text = "300";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = "400";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = "600";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = "700";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = "800";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text = "900";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1000";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2000";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3000";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            inputOne = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            arth_operator = "+";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            inputOne = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            arth_operator = "-";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            inputOne = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            arth_operator = "*";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            inputOne = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            arth_operator = "/";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".") == false)
            {
                textBox1.Text = textBox1.Text + ".";
            }
            else
            {
                MessageBox.Show("Decimal point is already there");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            if (arth_operator == "+")
            {
                result = inputOne + Convert.ToDecimal(textBox1.Text);
            }
            else if (arth_operator == "-")
            {
                result = inputOne - Convert.ToDecimal(textBox1.Text);
            }
            else if (arth_operator == "*")
            {
                result = inputOne * Convert.ToDecimal(textBox1.Text);
            }
            else if (arth_operator == "/")
            {
                if (textBox1.Text == "0")
                {
                    result = inputOne / Convert.ToDecimal(textBox1.Text);
                }
                else
                    MessageBox.Show("Enter value other than 0");
            }
            textBox1.Text = result.ToString();
        }
    }
    }
