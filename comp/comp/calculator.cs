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
    public partial class calculator : Form
    {
        int result = 0;
        int number1;
        int number2;
        public calculator()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)//*
        {
            number1 = Convert.ToInt32(numericUpDown1.Value);
            number2 = Convert.ToInt32(numericUpDown2.Value);
        
            result = number1 * number2;
            textBox3.Text = result.ToString();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//+
        {
            number1 = Convert.ToInt32(numericUpDown1.Value);
            number2 = Convert.ToInt32(numericUpDown2.Value);
            result = number1 + number2;
           textBox3.Text = result.ToString();
        }
        
        private void button2_Click(object sender, EventArgs e)//-
        {
            number1 = Convert.ToInt32(numericUpDown1.Value);
            number2 = Convert.ToInt32(numericUpDown2.Value);
            result = number1 - number2;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)//"/"
        {
            number1 = Convert.ToInt32(numericUpDown1.Value);
            number2 = Convert.ToInt32(numericUpDown2.Value);
            result = number1 / number2;
            textBox3.Text = result.ToString();
        }

        private void calculator_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)//clear
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox3.Text = null;
       
        }
    }
}
