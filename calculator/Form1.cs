using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string text = "";
        string text2 = "";
        string dos = "";
        private void button1_Click(object sender, EventArgs e)
        {
            text = text + "1";
            textBox1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = text + "2";
            textBox1.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text = text + "3";
            textBox1.Text = text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text = text + "4";
            textBox1.Text = text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text = text + "5";
            textBox1.Text = text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            text = text + "6";
            textBox1.Text = text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text = text + "7";
            textBox1.Text = text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text = text + "8";
            textBox1.Text = text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text = text + "9";
            textBox1.Text = text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            text = text + "0";
            textBox1.Text = text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            text = text + ",";
            textBox1.Text = text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (text.Length != 0){
                text = text.Substring(0, text.Length - 1);
                textBox1.Text = text;
            }
            
        }

       

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 About = new Form2();
            About.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            text2 = text;
            dos = "*";
            text = "";
            textBox1.Text = text;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (dos == "*")
            {


                text = Convert.ToString(Convert.ToDouble(text2) * Convert.ToDouble(text));
                textBox1.Text = text;
                dos = "";
            }
            if (dos == "-")
            {


                text = Convert.ToString(Convert.ToDouble(text2) - Convert.ToDouble(text));
                textBox1.Text = text;
                dos = "";
            }
            if (dos == "+")
            {


                text = Convert.ToString(Convert.ToDouble(text2) + Convert.ToDouble(text));
                textBox1.Text = text;
                dos = "";
            }
            if (dos == "/")
            {
                text = Convert.ToString(Convert.ToDouble(text2) / Convert.ToDouble(text));
                textBox1.Text = text;
                dos = "";
            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            text = "";
            text2 = "";
            textBox1.Text = text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            text2 = text;
            dos = "-";
            text = "";
            textBox1.Text = text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            text2 = text;
            dos = "+";
            text = "";
            textBox1.Text = text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            text2 = text;
            dos = "/";
            text = "";
            textBox1.Text = text;
        }


    }
}
