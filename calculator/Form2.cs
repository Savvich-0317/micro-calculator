using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //Я не знаю что это
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/Savvich-0317/calculator");
            Process.Start(sInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 License = new Form3();
            License.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Qr = new Form4();
            Qr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
