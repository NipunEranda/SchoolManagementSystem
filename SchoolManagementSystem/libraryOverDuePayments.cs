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
    public partial class libraryOverDuePayments : LibraryMainWindow
    {
        schoolDBDataContext obj = new schoolDBDataContext();
        private string btnStatus = "view";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TM7VHQ4; Initial Catalog=sms;Integrated Security=true;MultipleActiveResultSets=true");

        public libraryOverDuePayments()
        {
            InitializeComponent();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MainClass.disable_reset(panel6);
                var dataSet = obj.libraryOverdueSearch(txtSearch.Text);
                overDueIDGV.DataPropertyName = "overdue_ID";
                memberIDGV.DataPropertyName = "member_ID";
                dueDateGV.DataPropertyName = "dueDate";
                noOfDueDaysGV.DataPropertyName = "noOfDueDays";
                totalAmountGV.DataPropertyName = "totalAmount";
                overdueGridView.DataSource = dataSet;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void overDuePayments_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            showOverduePaymentsDetails();
        }

        private void overdueGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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
                i = Convert.ToInt32(overdueGridView.SelectedCells[0].Value.ToString());
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from libraryOverDue where overdue_ID='" + i + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtOverDueID.Text = dr["overdue_ID"].ToString();
                    txtMemberID.Text = dr["member_ID"].ToString();
                    DueDate.Text = dr["dueDate"].ToString();
                    txtDueDays.Text = dr["noOfDueDays"].ToString();
                    totalAmount.Text = dr["totalAmount"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            con.Close();
        }

        private void txtOverDueID_TextChanged(object sender, EventArgs e)
        {
            if(txtOverDueID.Text == "")
            {
                OverDueIDNull.Visible = true;
            }
            else
            {
                OverDueIDNull.Visible = false;
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

        private void DueDate_ValueChanged(object sender, EventArgs e)
        {
            if (DueDate.Text == "")
            {
                DueDateNull.Visible = true;
            }
            else
            {
                DueDateNull.Visible = false;
            }
        }

        private void txtDueDays_TextChanged(object sender, EventArgs e)
        {
            if(txtDueDays.Text == "")
            {
                DueDaysNull.Visible = true;
            }
            else
            {
                DueDaysNull.Visible = false;
            }
        }

        private void txtPerDayAmount_TextChanged(object sender, EventArgs e)
        {
            if(txtPerDayAmount.Text == "")
            {
                PerDayAmountNull.Visible = true;
            }
            else
            {
                PerDayAmountNull.Visible = false;
            }
        }

        private void btnCalculateAndSubmit_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add")
            {
                try
                {
                    int days, amount, total;

                    days = Convert.ToInt32(txtDueDays.Text);
                    amount = Convert.ToInt32(txtPerDayAmount.Text);

                    total = days * amount;
                    totalAmount.Text = total.ToString();
                }
                catch
                {
                    
                }
                if (OverDueIDNull.Visible || MemberIDNull.Visible || DueDateNull.Visible || DueDaysNull.Visible || PerDayAmountNull.Visible)
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
                            string q = "INSERT INTO libraryOverDue (overdue_ID, member_ID, dueDate, noOfDueDays, totalAmount) VALUES ('" + txtOverDueID.Text + "','" + txtMemberID.Text + "','" + DueDate.Text + "','" + txtDueDays.Text + "','" + totalAmount.Text + "')";
                            Console.Write(q);
                            SqlCommand cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            MainClass.showMsg(" Payment added Successfully!", "Success", "success");
                        }
                    }
                    catch
                    {
                        int overdue_ID = 0;
                        int member_ID = 0;

                        try
                        {
                            overdue_ID = int.Parse(txtOverDueID.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Overdue ID should be a numerical value!", "Warning", "Error");
                        }
                        try
                        {
                            member_ID = int.Parse(txtMemberID.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Member ID should be a numerical value!", "Warning", "Error");
                        }
                    }
                }
                con.Close();
                lblMain.Text = "View";
                showOverduePaymentsDetails();                
                MainClass.disable_reset(panel6);
            }
              else if (btnStatus == "update")
              {
                try
                {
                    int days, amount, total;

                    days = Convert.ToInt32(txtDueDays.Text);
                    amount = Convert.ToInt32(txtPerDayAmount.Text);

                    total = days * amount;
                    totalAmount.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                if (OverDueIDNull.Visible || MemberIDNull.Visible || DueDateNull.Visible || DueDaysNull.Visible || PerDayAmountNull.Visible)
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
                            string q = "UPDATE libraryOverDue SET overdue_ID ='" + txtOverDueID.Text + "' ,member_ID='" + txtMemberID.Text + "',dueDate='" + DueDate.Text + "',noOfDueDays='" + txtDueDays.Text + "',totalAmount='" + totalAmount.Text + "' where overdue_ID ='" + txtOverDueID.Text + "' ";
                            Console.Write(q);
                            SqlCommand cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            MainClass.showMsg("Details Updated Successfully", "Success", "success");
                        }
                    }
                    catch
                    {

                    }     
                }
                con.Close();
                lblMain.Text = "View";
                showOverduePaymentsDetails();
                MainClass.disable_reset(panel6);              
            }
           }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOverDueID.Text = "";
            txtMemberID.Text = "";
            DueDate.Text = "";
            txtDueDays.Text = "";
            txtPerDayAmount.Text = "";
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
                lblMain.Text = "Add OD Payment";
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
                lblMain.Text = "Update OD Payment";
                MainClass.enable(panel6);
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtOverDueID.Text != "")
            {
                DialogResult dr = MessageBox.Show("Do you want to delete " + "'s Details ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "DELETE libraryOverDue  where overdue_ID ='" + txtOverDueID.Text + "' ";
                        Console.Write(q);
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();
                        MainClass.showMsgLibrary("Successfully Deleted!", "Success", "Success");
                    }
                }
                else { }
            }
            else
            {
                MainClass.showMsg("Select a record that you want to delete!", "error", "error");
            }
            con.Close();
            showOverduePaymentsDetails();
            MainClass.disable_reset(panel6);
            lblMain.Text = "View";
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            btnStatus = "view";
            lblMain.Text = "View";
            showOverduePaymentsDetails();
            MainClass.disable_reset(panel6);
        }
        
        public void showOverduePaymentsDetails()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from libraryOverDue";
                overDueIDGV.DataPropertyName = "overdue_ID";
                memberIDGV.DataPropertyName = "member_ID";
                dueDateGV.DataPropertyName = "dueDate";
                noOfDueDaysGV.DataPropertyName = "noOfDueDays";
                totalAmountGV.DataPropertyName = "totalAmount";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                overdueGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }        
    }
}
