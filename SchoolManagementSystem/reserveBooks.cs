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
    public partial class reserveBooks : LibraryMainWindow
    {
        private string btnStatus = "view";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TM7VHQ4; Initial Catalog=sms;Integrated Security=true;MultipleActiveResultSets=true");
        schoolDBDataContext obj = new schoolDBDataContext();
        public reserveBooks()
        {
            InitializeComponent();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
             MainClass.disable_reset(panel6);
             var dataSet = obj.libraryReserveSearch(txtSearch.Text);
             reserveIDGV.DataPropertyName = "reserve_ID";
             bookIDGV.DataPropertyName = "book_ID";
             bookNameGV.DataPropertyName = "bookName";
             memberIDGV.DataPropertyName = "member_ID";
             reserveDateGV.DataPropertyName = "reserveDate";
             dueDateGV.DataPropertyName = "dueDate";
             ReserveGridView.DataSource = dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void txtReserveID_TextChanged(object sender, EventArgs e)
        {
            if (txtReserveID.Text == "")
            {
                ReserveIDNull.Visible = true;
            }
            else
            {
                ReserveIDNull.Visible = false;
            }
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                BookIDNull.Visible = true;
            }
            else
            {
                BookIDNull.Visible = false;
            }
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
        }

        private void ReserveDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DueDate_ValueChanged(object sender, EventArgs e)
        {
            if (DueDate.Value.ToString() == "")
            {
                DueDateNull.Visible = true;
            }
            else
            {
                DueDateNull.Visible = false;
            }
        }

        private void ReserveGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = Convert.ToInt32(ReserveGridView.SelectedCells[0].Value.ToString());
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
                    txtReserveID.Text = dr["reserve_ID"].ToString();
                    txtBookID.Text = dr["book_ID"].ToString();
                    txtBookName.Text = dr["bookName"].ToString();
                    txtMemberID.Text = dr["member_ID"].ToString();
                    ReserveDate.Text = dr["reserveDate"].ToString();
                    DueDate.Text = dr["dueDate"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void reserveBooks_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            showReserveDetails();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add")
            {
                
                if (ReserveIDNull.Visible || BookIDNull.Visible || BookNameNull.Visible || MemberIDNull.Visible)
                {
                    MainClass.showMsgLibrary("Fields with * are mandetory!", "Warning", "Error");
                }
                else
                {
                    try
                    {
                        con.Open();
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            int bookQty = 0;
                            SqlCommand cmd3 = con.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "SELECT * FROM libraryBooks WHERE name='" + txtBookName.Text + "'";
                            cmd3.ExecuteNonQuery();
                            DataTable dt2 = new DataTable();
                            SqlDataAdapter da2 = new SqlDataAdapter(cmd3);
                            da2.Fill(dt2);
                            foreach (DataRow dr2 in dt2.Rows)
                            {
                                bookQty = int.Parse(dr2["quantity"].ToString());
                            }

                            if (bookQty > 0)
                            {
                                SqlCommand cmd = con.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "INSERT INTO libraryReserveBooks (reserve_ID, book_ID, bookName, member_ID, reserveDate, dueDate)  VALUES ('" + txtReserveID.Text + "', '" + txtBookID.Text + "', '" + txtBookName.Text + "', '" + txtMemberID.Text + "', '" + ReserveDate.Text + "', '" + DueDate.Text + "')";
                                cmd.ExecuteNonQuery();
                                MainClass.showMsgLibrary("Successfull Reserved!", "Success", "Success");

                                SqlCommand cmd2 = con.CreateCommand();
                                cmd2.CommandType = CommandType.Text;
                                cmd2.CommandText = "UPDATE libraryBooks set quantity= quantity-1 where name='" + txtBookName.Text + "'";
                                cmd2.ExecuteNonQuery();
                            }
                            else
                            {
                                MainClass.showMsgLibrary("Book has already reserved!", "Warning", "Error");
                            }
                        }
                    }
                    catch
                    {
                        int reserveID = 0;
                        int bookID = 0;
                        int memberID = 0;

                        try
                        {
                            reserveID = int.Parse(txtReserveID.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Reserve ID should be a numerical value!", "Warning", "Error");
                        }

                        try
                        {
                            bookID = int.Parse(txtBookID.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Book ID should be a numerical value!", "Warning", "Error");
                        }
                        try
                        {
                            memberID = int.Parse(txtMemberID.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Member ID should be a numerical value!", "Warning", "Error");
                        }
                    }
                    
                    con.Close();
                    showReserveDetails();
                    lblMain.Text = "View";
                    MainClass.disable_reset(panel6);
                }
            }
            else if (btnStatus == "update")
            {
                if (ReserveIDNull.Visible || BookIDNull.Visible || MemberIDNull.Visible)
                {
                    MainClass.showMsgLibrary("Fields with * are mandetory!", "Warning", "Error");
                }
                else
                {
                    try
                    {
                        con.Open();
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            int bookQty = 0;
                            SqlCommand cmd3 = con.CreateCommand();
                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "SELECT * FROM libraryBooks WHERE name='" + txtBookName.Text + "'";
                            cmd3.ExecuteNonQuery();
                            DataTable dt2 = new DataTable();
                            SqlDataAdapter da2 = new SqlDataAdapter(cmd3);
                            da2.Fill(dt2);
                            foreach (DataRow dr2 in dt2.Rows)
                            {
                                bookQty = int.Parse(dr2["quantity"].ToString());
                            }

                            if(bookQty > 0)
                            {
                                string q = "UPDATE libraryReserveBooks SET reserve_ID ='" + txtReserveID.Text + "' ,book_ID='" + txtBookID.Text + "',bookName='" + txtBookName.Text + "', member_ID='" + txtMemberID.Text + "',reserveDate='" + ReserveDate.Text + "',dueDate='" + DueDate.Text + "' where reserve_ID ='" + txtReserveID.Text + "' ";
                                Console.Write(q);
                                SqlCommand cmd = new SqlCommand(q, con);
                                cmd.ExecuteNonQuery();
                                MainClass.showMsgLibrary("Successfull Updated!", "Success", "Success");

                                SqlCommand cmd2 = con.CreateCommand();
                                cmd2.CommandType = CommandType.Text;
                                cmd2.CommandText = "UPDATE libraryBooks set quantity= quantity-1 where name='" + txtBookName.Text + "'";
                                cmd2.ExecuteNonQuery();
                            }
                            else
                            {
                                MainClass.showMsgLibrary("all books has reserved!", "Warning", "Error");
                            }
                        }
                    }
                    catch
                    {
                        int bookID = 0;
                        int memberID = 0;

                        try
                        {
                            bookID = int.Parse(txtBookID.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Book ID should be a numerical value!", "Warning", "Error");
                        }
                        try
                        {
                            memberID = int.Parse(txtMemberID.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Member ID should be a numerical value!", "Warning", "Error");
                        }
                    }                  
                }
            }
            con.Close();
            showReserveDetails();
            lblMain.Text = "View";
            MainClass.disable_reset(panel6);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReserveID.Text = "";
            txtBookID.Text = "";
            txtMemberID.Text = "";
            DueDate.Text = "";
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add")
            {
                btnStatus = "view";
                lblMain.Text = "View";
                MainClass.disable(panel6);
            }
            else
            {
                btnStatus = "add";
                lblMain.Text = "Add Reservation";
                MainClass.enable_reset(panel6);
            }
        }

        public override void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnStatus == "update")
            {
                btnStatus = "view";
                lblMain.Text = "View";
                MainClass.disable(panel6);
            }
            else
            {
                btnStatus = "update";
                lblMain.Text = "Update Reservation";
                MainClass.enable(panel6);
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtReserveID.Text != "")
            {
             DialogResult dr = MessageBox.Show("Do you want to delete Reservation" + txtReserveID.Text + " Details ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dr == DialogResult.Yes)
             {
                    try
                    {
                        con.Open();
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            string q = "DELETE libraryReserveBooks  where reserve_ID ='" + txtReserveID.Text + "' ";
                            Console.Write(q);
                            SqlCommand cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            MainClass.showMsgLibrary("Successfully Deleted!", "Success", "Success");

                            SqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "UPDATE libraryBooks set quantity= quantity+1 where name='" + txtBookName.Text + "'";
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                else { }               
            }
            else
            {
                MainClass.showMsg("Select a record that you want to delete!", "error", "error");
            }
            con.Close();
            showReserveDetails();
            lblMain.Text = "View";
            MainClass.disable_reset(panel6);
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            btnStatus = "view";
            lblMain.Text = "View";
            showReserveDetails();
            MainClass.disable_reset(panel6);
        }

        public void showReserveDetails()
        {
            try
           {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from libraryReserveBooks";
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
                ReserveGridView.DataSource = dt;
               con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }      
    }    
}
