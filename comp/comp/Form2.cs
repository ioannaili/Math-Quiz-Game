using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int num, ans;
        int count;

        private void button2_Click(object sender, EventArgs e)//2
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)//1
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)//clear
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)//0
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)//+
        {
            num = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";

        }

        private void button13_Click(object sender, EventArgs e)//-
        {
            num = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button14_Click(object sender, EventArgs e)//*
        {
            num = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button15_Click(object sender, EventArgs e)//"/"
        {
            num = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button10_Click(object sender, EventArgs e)//=
        {
            calculate();
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int len = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i = 0; i < len; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        public void calculate()
        {
            if (count == 1)
            {
                ans = num + int.Parse(textBox1.Text);
                textBox1.Text = ans.ToString();
            }
            else if (count == 2)
            {

                ans = num - int.Parse(textBox1.Text);
                textBox1.Text = ans.ToString();
            }
            else if (count == 3)
            {
                ans = num * int.Parse(textBox1.Text);
                textBox1.Text = ans.ToString();
            }
            else if (count == 4)
            {
                ans = num / int.Parse(textBox1.Text);
                textBox1.Text = ans.ToString();
            }
            
        }
    }
}
