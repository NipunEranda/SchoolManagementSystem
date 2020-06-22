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
    public partial class addMembers : LibraryMainWindow
    {
        private string btnStatus = "view";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TM7VHQ4; Initial Catalog=sms;Integrated Security=true;MultipleActiveResultSets=true");
        schoolDBDataContext obj = new schoolDBDataContext();
        public addMembers()
        {
            InitializeComponent();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            var dataSet = obj.libraryMemberSearch(txtSearch.Text);
            memberIDGV.DataPropertyName = "member_ID";
            FnameGV.DataPropertyName = "FirstName";
            LnameGV.DataPropertyName = "LastName";
            addressGV.DataPropertyName = "address";
            contactGV.DataPropertyName = "contactNo";
            dateGV.DataPropertyName = "addDate";
            MemberGridView.DataSource = dataSet;
        }

        private void addMembers_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            showMemberDetails();
        }

        private void MemberGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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
                i = Convert.ToInt32(MemberGridView.SelectedCells[0].Value.ToString());
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from libraryMember where member_ID='" + i + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtMemberID.Text = dr["member_ID"].ToString();
                    txtFName.Text = dr["FirstName"].ToString();
                    txtLName.Text = dr["LastName"].ToString();
                    txtAddress.Text = dr["address"].ToString();
                    txtContact.Text = dr["contactNo"].ToString();
                    AddDate.Text = dr["addDate"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            con.Close();
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

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                FNameNull.Visible = true;
            }
            else
            {
                FNameNull.Visible = false;
            }
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if (txtLName.Text == "")
            {
                LNameNull.Visible = true;
            }
            else
            {
                LNameNull.Visible = false;
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                AddressNull.Visible = true;
            }
            else
            {
                AddressNull.Visible = false;
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text == "")
            {
                ContactNull.Visible = true;
            }
            else
            {
                ContactNull.Visible = false;
            }
        }

        private void AddDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMembers_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add")
            {
                if (MemberIDNull.Visible || FNameNull.Visible || LNameNull.Visible || AddressNull.Visible || ContactNull.Visible)
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
                           string q = "INSERT INTO libraryMember (member_ID, FirstName, LastName, address, contactNo, addDate) VALUES ('" + txtMemberID.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + AddDate.Text + "')";
                           Console.Write(q);
                           SqlCommand cmd = new SqlCommand(q, con);
                           cmd.ExecuteNonQuery();
                           MainClass.showMsg(txtFName.Text + " 's Details Added Successfully", "Success", "success");
                        }
                    }
                    catch
                    {
                        int member_ID = 0;
                        int contactNo = 0;

                        try
                        {
                            member_ID = int.Parse(txtMemberID.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Member ID should be a numerical Value!", "Warning", "Error");
                        }
                        try
                        {
                            contactNo = int.Parse(txtContact.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Contact no should be an integer!", "Warning", "Error");
                        }
                    }
                }
                con.Close();
                lblMain.Text = "View";
            }

            else if (btnStatus == "update")
            {
                if (MemberIDNull.Visible || FNameNull.Visible || LNameNull.Visible || AddressNull.Visible || ContactNull.Visible)
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
                            string q = "UPDATE libraryMember SET member_ID ='" + txtMemberID.Text + "' ,FirstName='" + txtFName.Text + "',LastName='" + txtLName.Text + "',address='" + txtAddress.Text + "',contactNo='" + txtContact.Text + "',addDate='" + AddDate.Text + "' where member_ID ='" + txtMemberID.Text + "' ";
                            Console.Write(q);
                            SqlCommand cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            MainClass.showMsg(txtFName.Text + " 's Details Updated Successfully", "Success", "success");
                        }
                    }
                    catch
                    {
                        int contactNo = 0;

                        try
                        {
                            contactNo = int.Parse(txtContact.Text);
                        }
                        catch
                        {
                            MainClass.showMsgLibrary("Contact no should be a numerical!", "Warning", "Error");
                        }
                    }
                   
                }               
            }
            con.Close();
            showMemberDetails();
            MainClass.disable_reset(panel6);
            lblMain.Text = "View";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemberID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
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
                lblMain.Text = "Add Member";
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
                lblMain.Text = "Update Member";
                MainClass.enable(panel6);
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text != "")
            {
                DialogResult dr = MessageBox.Show("Do you want to delete " + txtFName.Text + "'s Details ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        try
                        {
                            string q = "DELETE libraryMember  where member_ID ='" + txtMemberID.Text + "' ";
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
            showMemberDetails();
            lblMain.Text = "View";
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            btnStatus = "view";
            lblMain.Text = "View";
            showMemberDetails();
            MainClass.disable_reset(panel6);            
        }

        public void showMemberDetails()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from libraryMember";
                memberIDGV.DataPropertyName = "member_ID";
                FnameGV.DataPropertyName = "FirstName";
                LnameGV.DataPropertyName = "LastName";
                addressGV.DataPropertyName = "address";
                contactGV.DataPropertyName = "contactNo";
                dateGV.DataPropertyName = "addDate";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                MemberGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }      
    }
}