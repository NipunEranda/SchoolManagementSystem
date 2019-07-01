using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    public partial class Login : Form
    {

        MainClass main = new MainClass();
        MySqlConnection con;
        bool status = false;

        public Login(MySqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }


        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            string query = "select * from users where userName = '" + userName.Text.Trim() + "' and password = '" + password.Text.Trim() + "'";
            MySqlDataAdapter dataAdapt = new MySqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            dataAdapt.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                status = true;
                this.Close();
            }
            else
            {
                status = false;
                MessageBox.Show("Incorrect username or password");
            }
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
