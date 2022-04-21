using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_643450330_1_
{
    public partial class Form1 : Form
    {
        int NUM1, NUM2, NUM3;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            NUM1 = int.Parse(Display.Text);
            Display.Text = "";
            op = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            NUM1 = int.Parse(Display.Text);
            Display.Text = "";
            op = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            NUM1 = int.Parse(Display.Text);
            Display.Text = "";
            op = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            NUM1 = int.Parse(Display.Text);
            Display.Text = "";
            op = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            NUM2 = int.Parse(Display.Text);
            if (op == "+")
            {
                NUM3 = NUM1 + NUM2;
                Display.Text = NUM3.ToString();
            }//Close +
            if (op == "-")
            {
                NUM3 = NUM1 - NUM2;
                Display.Text = NUM3.ToString();
            }//Close -
            if (op == "*")
            {
                NUM3 = NUM1 * NUM2;
                Display.Text = NUM3.ToString();
            }//Close *
            if (op == "/")
            {
                NUM3 = NUM1 / NUM2;
                Display.Text = NUM3.ToString();
            }//Close /

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Display.Text =  "";
        }
    }
}
