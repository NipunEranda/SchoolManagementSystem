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
    public partial class returnBooks : LibraryMainWindow
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TM7VHQ4; Initial Catalog=sms;Integrated Security=true;MultipleActiveResultSets=true");
        public returnBooks()
        {
            InitializeComponent();
        }

        private void returnBooks_Load(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
            txtSearch.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnView.Visible = false;
        }

        private void returnGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = Convert.ToInt32(returnGridView.SelectedCells[0].Value.ToString());
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from libraryReserveBooks where reserve_ID='" + i + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ReserveIDText.Text = dr["reserve_ID"].ToString();
                    BookIDText.Text = dr["book_ID"].ToString();
                    BookNameText.Text = dr["bookName"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            if (txtMemberID.Text == "")
            {
                MemberIDNull.Visible = true;
            }
            else
            {
                MemberIDNull.Visible = false;
            }

            showDetails(txtMemberID.Text);
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "DELETE libraryReserveBooks  where reserve_ID ='" + ReserveIDText.Text + "' ";
                    Console.Write(q);
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "UPDATE libraryBooks set quantity= quantity+1 where name='" + BookNameText.Text + "'";
                    cmd2.ExecuteNonQuery();
                    MainClass.showMsgLibrary("Book has returned!", "Success", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            con.Close();
            dataClear();
            showDetails(txtMemberID.Text);
        }

        public void showDetails(string memID)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from libraryReserveBooks where member_ID ='" + memID.ToString() + "'";
                reserveIDGV.DataPropertyName = "reserve_ID";
                bookIDGV.DataPropertyName = "book_ID";
                bookNameGV.DataPropertyName = "bookName";
                memberIDGV.DataPropertyName = "member_ID";
                reserveDateGV.DataPropertyName = "reserveDate";
                dueDateGV.DataPropertyName = "dueDate";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                returnGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void dataClear()
        {
            txtMemberID.Text = "";
            ReserveIDText.Text = "";
            BookIDText.Text = "";
            BookNameText.Text = "";
        }
    }
}
