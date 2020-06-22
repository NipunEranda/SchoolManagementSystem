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
    public partial class addBooks : LibraryMainWindow
    {
        private string btnStatus = "view";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TM7VHQ4;Initial Catalog=sms;Integrated Security=True");
        schoolDBDataContext obj = new schoolDBDataContext();
        public addBooks()
        {
            InitializeComponent();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MainClass.disable_reset(panel6);
                var dataSet = obj.libraryBookSearch(txtSearch.Text);
                BookIDGV.DataPropertyName = "book_ID";
                BookNameGV.DataPropertyName = "name";
                AuthorGV.DataPropertyName = "author";
                DateGV.DataPropertyName = "addDate";
                BookGridView.DataSource = dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }          
        }

        private void addBooks_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            showBookDetails();
        }

        private void BookGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnStatus == "view" || btnStatus == "add")
            {
                MainClass.disable(panel6);
            }
            else
            {
                MainClass.enable(panel6);
            }

            try
            {
                int i;
                i = Convert.ToInt32(BookGridView.SelectedCells[0].Value.ToString());
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from libraryBooks where book_ID='" + i + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtBookID.Text = dr["book_ID"].ToString();
                    txtBookName.Text = dr["name"].ToString();
                    txtAuthor.Text = dr["author"].ToString();
                    AddDate.Text = dr["addDate"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            con.Close();
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

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "")
            {
                AuthorNull.Visible = true;
            }
            else
            {
                AuthorNull.Visible = false;
            }
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add")
            {
                if (BookIDNull.Visible || BookNameNull.Visible || AuthorNull.Visible)
                {
                    MainClass.showMsg("Fields with * are mandetory!", "Warning", "Error");
                }
                else
                {
                    try
                    {
                        con.Open();
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                        string q = "INSERT INTO libraryBooks (book_ID, name, author, quantity, addDate) VALUES ('" + txtBookID.Text + "','" + txtBookName.Text + "','" + txtAuthor.Text + "', '1', '" + AddDate.Text + "')";
                        Console.Write(q);
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        MainClass.showMsgLibrary(txtBookName.Text+ "Successfully Added!", "Success", "Success");
                    }

                    }
                    catch
                    {
                        int book_ID = 0;

                        try
                        {
                            book_ID = int.Parse(txtBookID.Text);
                        }
                        catch
                        {
                            MainClass.showMsg("Book ID should be an numerical value!", "Warning", "Error");
                        }

                    }
                }
                con.Close();
                lblMain.Text = "View";
            }
            else if (btnStatus == "update")
            {
                if (BookIDNull.Visible || BookNameNull.Visible || AuthorNull.Visible)
                {
                    MainClass.showMsg("Fields with * are mandetory!", "Warning", "Error");
                }
                else
                {
                    try
                    {
                        con.Open();
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            string q = "UPDATE libraryBooks SET book_ID ='" + txtBookID.Text + "' ,name='" + txtBookName.Text + "',author='" + txtAuthor.Text + "',quantity='1',addDate='" + AddDate.Text + "' where book_ID ='" + txtBookID.Text + "' ";
                            Console.Write(q);
                            SqlCommand cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            MainClass.showMsgLibrary("Successfull Updated!", "Success", "Success");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
            con.Close();
            showBookDetails();
            MainClass.disable_reset(panel6);
            lblMain.Text = "View";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Text = "";
            txtBookName.Text = "";
            txtAuthor.Text = "";
            AddDate.Text = "";
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
                lblMain.Text = "Add Book";
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
                lblMain.Text = "Update Book";
                MainClass.enable(panel6);
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text != "")
            {
             DialogResult dr = MessageBox.Show("Do you want to delete " + txtBookName.Text + "? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dr == DialogResult.Yes)
             {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        string q = "DELETE libraryBooks  where book_ID ='" + txtBookID.Text + "' ";
                        Console.Write(q);
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        MainClass.showMsgLibrary("Successfully Deleted!", "Success", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                else { }
            }
           }
            else
            {
                MainClass.showMsg("Select a record that you want to delete!", "error", "error");
            }
            con.Close();
            MainClass.disable_reset(panel6);
            showBookDetails();
            lblMain.Text = "View";
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            btnStatus = "view";
            lblMain.Text = "View";
            showBookDetails();
            MainClass.disable_reset(panel6);
        }

        public void showBookDetails()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select book_ID, name, author, addDate  from libraryBooks";
                BookIDGV.DataPropertyName = "book_ID";
                BookNameGV.DataPropertyName = "name";
                AuthorGV.DataPropertyName = "author";
                DateGV.DataPropertyName = "addDate";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                BookGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }         
        }
    }
}
