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
            if (text.Contains(',')==false)
            {

                text = text + ",";
                textBox1.Text = text;
            }
            
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


        private void button14_Click(object sender, EventArgs e)
        {
            if(text == ",")
            {
                text = text = "";
                textBox1.Text = "Wrong format";
                return;
            }

            if (text2 != "" && text != "")
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
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (text == ",")
            {
                text = text2 = "";
                textBox1.Text = "Wrong format";
            }
            else
            {

                text2 = text;
                dos = "*";
                text = "";
                textBox1.Text = text;
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
            if (text == ",")
            {
                text = text2 = "";
                textBox1.Text = "Wrong format";
            }
            else
            {
                text2 = text;
                dos = "-";
                text = "";
                textBox1.Text = text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (text == ",")
            {
                text = text2 = "";
                textBox1.Text = "Wrong format";
            }
            else
            {
                text2 = text;
                dos = "+";
                text = "";
                textBox1.Text = text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (text == ",")
            {
                text = text2 = "";
                textBox1.Text = "Wrong format";
            }
            else
            {
                text2 = text;
                dos = "/";
                text = "";
                textBox1.Text = text;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (text == ",")
            {
                text = text2 = "";
                textBox1.Text = "Wrong format";
            }
            else
            {
                text2 = text;
                text = Convert.ToString(Convert.ToDouble(text2) / 100);
                textBox1.Text = text;
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (text == ",")
            {
                text = text2 = "";
                textBox1.Text = "Wrong format";
            }
            else
            {
                text2 = text;
                text = Convert.ToString(Math.Sqrt(Convert.ToDouble(text2)));
                textBox1.Text = text;
            }
        }


        private void button22_Click(object sender, EventArgs e)
        {
            if (text.Length >= 1)
            {


                if (text[0] != '-')
                {
                    text = '-' + text;
                }
                else
                {
                    text = text.Substring(1, text.Length - 1);
                }
            }
            textBox1.Text = text;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            text = "";
            textBox1.Text = text;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();

                ToolTip1.SetToolTip(this.button13, "Multiplies.");
                ToolTip1.SetToolTip(this.button18, "Divides.");
                ToolTip1.SetToolTip(this.button16, "Subtracts");
                ToolTip1.SetToolTip(this.button17, "Summarizes");
                ToolTip1.SetToolTip(this.button20, "Calculates one percent.");

                ToolTip1.SetToolTip(this.button11, "Clears one character of the active field.");
                ToolTip1.SetToolTip(this.button23, "Clears the active field.");
                ToolTip1.SetToolTip(this.button15, "Cleans everything.");
                ToolTip1.SetToolTip(this.button21, "Calculates the square root");
                ToolTip1.SetToolTip(this.button19, "Adds the fractional part of the active field");
                ToolTip1.SetToolTip(this.button22, "Inverts sign");


            }
            else
            {
                
            }
            
        }
    }
}
