using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class checkAvailability : LibraryMainWindow
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TM7VHQ4; Initial Catalog=sms;Integrated Security=true;MultipleActiveResultSets=true");
        schoolDBDataContext obj = new schoolDBDataContext();
        public checkAvailability()
        {
            InitializeComponent();
        }

        private void checkAvailability_Load(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
            txtSearch.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnView.Visible = false;
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text == "")
            {
                BookNameNull.Visible = true;
            }
            else
            {
                BookNameNull.Visible = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
           if (BookNameNull.Visible)
            {
                MainClass.showMsgLibrary("Book name should not be empty!", "Warning", "Error");
            }
            else
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT  SUM(quantity) FROM libraryBooks  where name ='" + txtBookName.Text + "' ";
                    Console.Write(q);
                    SqlCommand cmd = new SqlCommand(q, con);
                    SqlDataReader sqlr = cmd.ExecuteReader();
                    while (sqlr.Read())
                    {
                        string x = sqlr[0].ToString();
                        bookName.Text = x;
                    }
                }
                con.Close();
            }
        }
    }
}
