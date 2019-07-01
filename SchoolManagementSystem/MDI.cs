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
    public partial class MDI : Form
    {
        private MySqlConnection con;

        public MDI(MySqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.MdiParent = this;
            Home.WindowState = FormWindowState.Maximized;
            Home.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
