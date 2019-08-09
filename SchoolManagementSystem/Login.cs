using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace SchoolManagementSystem
{
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        MainClass main = MainClass.getInstance();
        bool status = false;

        public Login()
        {
            InitializeComponent();
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (main.setLogin(userName.Text, password.Text))
            {
                status = true;
                this.Close();
            }
            else {
                MainClass.showMsg("Login details invalid", "Error", "Error");
            }
        }

        public bool getStatus()
        {
            return status;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MainClass.appStatus = "exit";
            Application.Exit();
        }

        public bool loginCheck() {
            return true;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainClass.appStatus = "exit";
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {

        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) {
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
    }
}
