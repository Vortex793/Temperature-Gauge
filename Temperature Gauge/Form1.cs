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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            temp = Convert.ToInt32(txtTemp.Text);
            if (temp >= 0)
            {
                imgTemp.Image = Properties.Resources.blue_cold_freezing_face_emoticon_icicles_clinging_to_its_jaw_cheek_freezing_emoticon_139212847;
            }
            else if (temp <= 25)
            {
                imgTemp.Image = Properties.Resources.warm_temperature_at_spring_with_fine_weather_and_sun_2F5PMMY
            }
            else if (temp <= 40)
            {

            }
            else if (temp <= 100)
            {

            }
            if (temp >= 100)
            {

            }
            else
            {

            }
        }
    }
}
