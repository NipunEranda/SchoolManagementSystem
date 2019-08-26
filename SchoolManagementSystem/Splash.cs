using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Splash : Form
    {

        bool left = true;
        double percentage = 2;

        public Splash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            /*if (left && panelSlide.Left < 554)
            {
                panelSlide.Left += 2;
            }
            else {
                left = false;
            }

            if (left == false && panelSlide.Left > 0)
            {
                panelSlide.Left -= 2;
            }
            else {
                left = true;
            }*/
            if (panelSlide.Width < 900)
            {
                panelSlide.Width += 2;
                percentage = (panelSlide.Width / 900.0)*100;
                waitLabel.Text = Math.Round(percentage, 2).ToString() + "%";
            }
            else {

            }
            /*if (panelSlide.Width > 100)
            {
                waitLabel.Text =  "Loading Modules...";
            }
            if (panelSlide.Width > 200)
            {
                waitLabel.Text += "Loading Files...";
            }
            if (panelSlide.Width > 300)
            {
                waitLabel.Text += "Loading user data...";
            }
            if (panelSlide.Width > 350) {
                waitLabel.Text += "Configuring the application...";
            }
            if (panelSlide.Width > 400) {
                waitLabel.Text += "Loading...";
            }*/


        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
            timer.Start();
        }
    }
}
