using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BscCHAss1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {

                MessageBox.Show("Please select a conversion type", "error");

            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please select a conversion type", "error");
            }

            double input1 = double.Parse(textBox1.Text);

            int conversion = listBox1.SelectedIndex;

            double output1 = 0;

            if (radioButton1.Checked == true)
            {
                if (conversion == 0)
                {
                    output1 = input1 * 2.2;

                    
                } else if (conversion == 1)
                {
                    output1 = input1 * 1.75975326;

                } else if (conversion == 2)
                {
                    output1 = input1 * 0.404685642240001;

                } else if (conversion == 3)
                {
                    output1 = input1 * 0.3937007874;

                }

            }
            else if (radioButton2.Checked == true)
            {

                if (conversion == 0)
                {
                    output1 = input1 / 2.2;

                }
                else if (conversion == 1)
                {
                    output1 = input1 / 1.75975326;

                }
                else if (conversion == 2)
                {
                    output1 = input1 / 0.404685642240001;

                }
                else if (conversion == 3)
                {
                    output1 = input1 / 0.3937007874;

                }


            }

            textBox2.Text = output1.ToString("N2");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "")
            {

                MessageBox.Show("Please enter a date, time and year", "error");

            }

            try
            {


                string inputdate = textBox3.Text;
                DateTime birthdate = DateTime.Parse(inputdate);
                DateTime nowdate = DateTime.Now;
                TimeSpan resdate = nowdate.Subtract(birthdate);
                int daysalive = resdate.Days;

                textBox5.Text = (daysalive + 1).ToString();




            }
            catch
            {


                MessageBox.Show("Invalid Input", "error");

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}