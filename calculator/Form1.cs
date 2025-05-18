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
            if (text.Contains(',') == false)
            {

                text = text + ",";
                textBox1.Text = text;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (text.Length != 0)
            {
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
            if (text == "," || text == "")
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
            if (text == "," || text == "")
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
            if (text == "," || text == "")
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
            if (text == "," || text == "")
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
            if (text == "," || text == "")
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
            if (text == "," || text == "")
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
            if (text == "," || text == "")
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
        //НЕМОЕ НАЧАЛО
        private System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
        // Объявляем как поле класса, так как иначе при нажатии на checkbox будет каждый раз создаваться новый tooltip

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Список всех кнопок с подсказками
            var buttonsWithTooltips = new[]
            {
            (button: button13, tip: "Multiplies."),
            (button: button18, tip: "Divides."),
            (button: button16, tip: "Subtracts."),
            (button: button17, tip: "Summarizes."),
            (button: button20, tip: "Calculates one percent."),
            (button: button11, tip: "Clears one character of the active field."),
            (button: button23, tip: "Clears the active field."),
            (button: button15, tip: "Cleans everything."),
            (button: button21, tip: "Calculates the square root."),
            (button: button19, tip: "Adds the fractional part of the active field."),
            (button: button22, tip: "Inverts sign.")
            };

            if (checkBox1.Checked)
            {
                foreach (var btn in buttonsWithTooltips)
                {
                    ToolTip1.SetToolTip(btn.button, btn.tip);
                }
            }
            else
            {
                foreach (var btn in buttonsWithTooltips)
                {
                    ToolTip1.SetToolTip(btn.button, "");
                }
            }
            //НЕМОЕ КОНЕЦ
        }
    }
}
