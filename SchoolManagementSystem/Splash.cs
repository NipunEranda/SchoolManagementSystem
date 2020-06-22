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

            if (panelSlide.Width < 900)
            {
                panelSlide.Width += 2;
                percentage = (panelSlide.Width / 901.0)*100;
                waitLabel.Text = Math.Round(percentage, 2).ToString() + "%";
            }
            else {

            }


        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
            timer.Start();
        }
    }
}
