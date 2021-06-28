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

        float argument_one;
        
        float argument_two;

        float result;

        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }


        private void calculate()
        {
            switch (operation)
            {
                case "plus":
                    result=argument_one + argument_two;
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
                    result = 1/argument_one;
                    textBox1.Text = result.ToString();
                    break;
            }
        }


        private void button14_Click(object sender, EventArgs e)    //  =
        {
            if (textBox1.Text != "") argument_two = float.Parse(textBox1.Text);
            calculate();
        }

        private void button13_Click(object sender, EventArgs e)    // + сложение
        {
            argument_one = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = "plus";
        }

        private void button18_Click(object sender, EventArgs e)   //  -
        {
            argument_one = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = "minus";
        }

        private void button17_Click(object sender, EventArgs e)  // *
        {
            argument_one = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = "multiply";
        }

        private void button16_Click(object sender, EventArgs e)  //   деление
        {
            argument_one = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = "split";
        }

        private void button12_Click(object sender, EventArgs e)  // операция 1/X
        {
            argument_one = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = "operation 1/X";
        }
    }
}