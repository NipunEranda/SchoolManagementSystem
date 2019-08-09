using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class MDI : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        MainClass main = MainClass.getInstance();
        string windowStatus = "normal";

        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
                Home home = new Home();
                MainClass.setCurrentForm(home);
                topic.Text = MainClass.current.Name;
                home.MdiParent = this;
                home.WindowState = FormWindowState.Maximized;
                home.Show();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MainClass.checkAction("Do you want to Exit?", "Exit");
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MainClass.appStatus = "";
                this.Close();
        }

        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainClass.appStatus != null)
            {
                DialogResult dr = MainClass.checkAction("Do you want to exit?", "Exit");
                if (dr == DialogResult.No)
                    e.Cancel = true;
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (windowStatus == "normal")
            {
                this.WindowState = FormWindowState.Maximized;
                windowStatus = "max";
            }
            else {
                this.WindowState = FormWindowState.Normal;
                windowStatus = "normal";
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public void setTopic(string name) {
            topic.Text = name;
        }
    }
}
