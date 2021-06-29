using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {

        float argument_one=0;

        float argument_two;

        float result;

        string operation;

        bool sign=true;

        bool dot = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 7;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)  ///  точка
        {
            if (dot == false && textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + ",";
                dot = true;
            }
        }


        private void calculate()
        {
            switch (operation)
            {
                case "plus":
                    result = argument_one + argument_two;
                    textBox1.Text = result.ToString();
                    break;
                case "minus":
                    result = argument_one - argument_two;
                    textBox1.Text = result.ToString();
                    break;
                case "multiply":
                    result = argument_one * argument_two;
                    textBox1.Text = result.ToString();
                    break;
                case "split":
                    result = argument_one / argument_two;
                    textBox1.Text = result.ToString();
                    break;
                case "operation 1/X":
                    result = 1 / argument_one;
                    textBox1.Text = result.ToString();
                    break;
                case "operation X^(1/Y)":
                    //result = argument_one / argument_one;
                    textBox1.Text = result.ToString();
                    break;
            }
        }


        private void button14_Click(object sender, EventArgs e)    //  =
        {
            if (textBox1.Text != "") argument_two = float.Parse(textBox1.Text);
            calculate();
            dot = false;
        }

        private void button13_Click(object sender, EventArgs e)    // + сложение
        {
            if (textBox1.Text != "" && textBox1.Text !="-")
            {
                argument_one = float.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "plus";
            }
            dot = false;
        }

        private void button18_Click(object sender, EventArgs e)   //  -
        {
            if (textBox1.Text != "" && textBox1.Text != "-")
            {
                argument_one = float.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "minus";
            }
            dot = false;
        }

        private void button17_Click(object sender, EventArgs e)  // *
        {
            if (textBox1.Text != "" && textBox1.Text != "-")
            {
                argument_one = float.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "multiply";
            }
            dot = false;
        }

        private void button16_Click(object sender, EventArgs e)  //   деление
        {
            if (textBox1.Text != "" && textBox1.Text != "-")
            {
                argument_one = float.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "split";
            }
            dot = false;
        }

        private void button12_Click(object sender, EventArgs e)  // операция 1/X
        {
            if (textBox1.Text != "" && textBox1.Text != "-")
            {
                argument_one = float.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "operation 1/X";
            }
            dot = false;
        }

        private void button15_Click(object sender, EventArgs e)   // операция  X^(1/Y)
        {
            if (textBox1.Text != "" && textBox1.Text != "-")
            {
                argument_one = float.Parse(textBox1.Text);
                textBox1.Clear();
                operation = "operation X^(1/Y)";
            }
            dot = false;
        }

        private void button19_Click(object sender, EventArgs e)    //  стереть все
        {
            dot = false;
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)    // удаление последнего элемента
        {
            if (textBox1.Text != "" && textBox1.Text != "-")
            {
                int lenght = textBox1.Text.Length - 1;
                string text = textBox1.Text;
                if (text[lenght] == ',') dot = false;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)  // смена знака
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)  // защита от ввода букв 
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }
    }
}