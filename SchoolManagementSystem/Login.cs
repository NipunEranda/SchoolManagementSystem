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

namespace SchoolManagementSystem
{
    public partial class Login : Form
    {

        MainClass main = MainClass.getInstance();
        SqlConnection con = DbConnection.getConnection();
        bool status = false;

        public Login()
        {
            InitializeComponent();
        }


        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            status = true;
            this.Close();
        }

        public bool getStatus()
        {
            return status;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
