using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace завдання1
{
    public partial class Form1 : Form
    {
        public int firstArg;
        public int secondArg;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        int Add() { return firstArg + secondArg;}
       
        int Subtract() { return firstArg - secondArg;}

        int Multiply() { return firstArg * secondArg;}
        string Divide() 
        {
            if (secondArg == 0)
            {
                label1.Text = "Error";
            }
            return Convert.ToString(firstArg / secondArg); 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            firstArg = int.Parse(textBox1.Text);
            secondArg = int.Parse(textBox2.Text);

            if (textBox3.Text == "+") 
                label1.Text += $"{Add()}";
            if (textBox3.Text == "-")
                label1.Text += $"{Subtract()}";
            if (textBox3.Text == "*") 
                label1.Text += $"{Multiply()}";
            if (textBox3.Text == "/")
                label1.Text += $"{Divide()}";

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
   
}
