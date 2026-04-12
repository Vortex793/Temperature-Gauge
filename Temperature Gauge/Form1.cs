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

namespace Temperature_Gauge
{
    public partial class Form1 : Form
    {
        //Curtis Apfelbeck
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;

            if (int.TryParse(textBox1.Text, out temp))
            {
                if (temp < 0)
                {
                    imgTemp.Image = Properties.Resources.very_cold;
                }
                else if (temp <= 25)
                {
                    imgTemp.Image = Properties.Resources.cold;
                }
                else if (temp <= 40)
                {
                    imgTemp.Image = Properties.Resources.warm;
                }
                else if (temp <= 100)
                {
                    imgTemp.Image = Properties.Resources.Hot;
                }
                else
                {
                    imgTemp.Image = Properties.Resources.Very_Warm;
                }
            }
            else
            {
                MessageBox.Show("Invalid number :(");
            }
        }
    }
}
