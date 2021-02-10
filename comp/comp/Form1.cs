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
    public partial class Form1 : Form
    {
        Random r = new Random();
        int time;
        int correct = 0;
        List<int> num = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//start quiz
        {
            timer1.Start();
            time = 90;
            groupBox2.Visible = false;
            buttonsubmit.Visible = true;
            button2.Visible = true;

             StartTheQuiz();
          
            Form2 c = new Form2();
            c.Show();
            c.SetDesktopLocation(this.Location.X + this.Size.Width, this.Location.Y);

        }
    
        public void StartTheQuiz()
        {
           
            for (int i = 0; i <= 7; i++)
            {
                num.Add(r.Next(1000));

            }

                label1.Text = num[0].ToString();
                label2.Text = num[1].ToString();
                label3.Text = num[2].ToString();
                label4.Text = num[3].ToString();
                label5.Text = num[4].ToString();
                label6.Text = num[5].ToString();
                label7.Text = num[6].ToString();
                label8.Text = num[7].ToString();
       
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            if (time > 0)
            {
                time--;
                timelabel.Text = time.ToString() +" "+ "seconds";
                if (time > 60)
                {
                    if (time == 61)
                    {
                        Class2 help = new Class2();
                        label15.Text=help.help =( "You have to submit only the interger part of the substraction");
                        label15.Visible = true;
                    }
                  
                    groupBox1.BackColor = Color.Green;
                }
                else if (time > 30)
                {
                    if (time == 31)
                    {
                        
                        Class3 help1 = new Class3();
                        labelhint1.Text = help1.help1 = ("BREATHE");
                        labelhint1.Visible = true;
                    }
                    groupBox1.BackColor = Color.Orange;

                }
               else
                {
                    groupBox1.BackColor = Color.Red;
                }
            }
            else
            {
                timer1.Stop();
                timelabel.Text = "Time's up";

            }
            
            
                 

        }

        private void button2_Click(object sender, EventArgs e)//clear
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {

        
            
            if (CheckTheAnswerAdd(num))
            {
                correct++;
                label12.Text = label12.Text + "Correct";
            }
            else
            {
                label12.Text = "1.Wrong the correct answer is"+" "+(num[0] + num[1]).ToString();
              
            }

            if (CheckTheAnswerSub(num))
            {
                correct++;
                labelsub.Text = labelsub.Text + "Correct";
            }
            else
            {
                labelsub.Text = "2.Wrong the correct answer is" +" "+ (num[2] - num[3]).ToString();
            }

            if (CheckTheAnswerMul(num))
            {
                correct++;
                label13.Text = label13.Text + "Correct";
            }
            else
            {
                label13.Text = "3.Wrong the correct answer is" + " "+ (num[4] * num[5]).ToString();
            }

            if (CheckTheAnswerDiv(num))
            {
                correct++;
                label14.Text = label14.Text + "Correct";
            }
            else
            {
                label14.Text = "4.Wrong the correct answer is" + " "+ (num[6] / num[7]).ToString();
            }

            if (time == 0)
            {
                labeltime.Text = "You run out of time";
            }
            else
            {
                labeltime.Text = "You had"+" " + time + " "+"seconds left";
            }
            buttonsubmit.Visible = false;
            button2.Visible = false;
            groupBox2.Visible = true;
            labelright.Text = correct.ToString();

        }
        
        

         public bool CheckTheAnswerAdd(List<int> num)
          {

              if (num[0] + num[1] == numericUpDown1.Value)
              {
                  return true;
              }
              else {

                  return false;
              }  
          }

          public bool CheckTheAnswerSub(List<int> num)
          {

              if (num[2] - num[3] == numericUpDown2.Value)
              {
                  return true;
              }
              else
              {

                  return false;
              }
          }

          public bool CheckTheAnswerMul(List<int> num)
          {

              if (num[4] * num[5] == numericUpDown3.Value)
              {
                  return true;
              }
              else
              {

                  return false;
              }
          }

          public bool CheckTheAnswerDiv(List<int> num)
          {

              if (num[6] / num[7] == numericUpDown4.Value)
              {
                  return true;
              }
              else
              {

                  return false;
              }
          }

      
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
           
        }

        private void labelhintt1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
