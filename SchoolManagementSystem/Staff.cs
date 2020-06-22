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
    public partial class Staff : Form

    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-TM7VHQ4;Initial Catalog=sms;Integrated Security=True");
        int eid = 0;

        

        public Staff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            

            try
            {
                ImageConverter imgCon = new ImageConverter();
                byte[] img = (byte[])imgCon.ConvertTo(staffpic.Image, Type.GetType("System.Byte[]"));

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (saveBtn.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("SatffAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@eid", 0);
                    sqlCmd.Parameters.AddWithValue("@ename", staffNameL.Text);
                    sqlCmd.Parameters.AddWithValue("@namewIni", staffNameIL.Text);
                    sqlCmd.Parameters.AddWithValue("@address", staffAddressL.Text);
                    sqlCmd.Parameters.AddWithValue("@nic", staffNicL.Text);
                    sqlCmd.Parameters.AddWithValue("@dob", staffDobL.Value);
                    sqlCmd.Parameters.AddWithValue("@phone", staffTelephoneL.Text);
                    sqlCmd.Parameters.AddWithValue("@department", staffDepartmentL.Text);
                    sqlCmd.Parameters.AddWithValue("@designation", staffDesignationL.Text);
                    sqlCmd.Parameters.AddWithValue("@doj", staffDojL.Value);
                    sqlCmd.Parameters.AddWithValue("@img", img);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("SatffAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@eid", eid);
                    sqlCmd.Parameters.AddWithValue("@ename", staffNameL.Text);
                    sqlCmd.Parameters.AddWithValue("@namewIni", staffNameIL.Text);
                    sqlCmd.Parameters.AddWithValue("@address", staffAddressL.Text);
                    sqlCmd.Parameters.AddWithValue("@nic", staffNicL.Text);
                   sqlCmd.Parameters.AddWithValue("@dob", staffDobL.Value);
                    sqlCmd.Parameters.AddWithValue("@phone", staffTelephoneL.Text);
                    sqlCmd.Parameters.AddWithValue("@department", staffDepartmentL.Text);
                    sqlCmd.Parameters.AddWithValue("@designation", staffDesignationL.Text);
                    sqlCmd.Parameters.AddWithValue("@doj", staffDojL.Value);
                    sqlCmd.Parameters.AddWithValue("@img", img);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfully");
                }
                Reset();
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        //imgbox
        private void staffpicBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    staffpic.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("StaffSearch",sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@staffName", staffSearchBox.Text);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            staffDb.DataSource = dtbl;
            staffDb.Columns[0].Visible = false;
            staffDb.Columns[10].Visible = false;

            sqlCon.Close();
        }

        private void staffSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void staffDb_DoubleClick(object sender, EventArgs e)
        {
            if(staffDb.CurrentRow.Index != -1)
            {
                eid = Convert.ToInt32(staffDb.CurrentRow.Cells[0].Value.ToString());
                staffNameL.Text = staffDb.CurrentRow.Cells[1].Value.ToString();
                staffNameIL.Text = staffDb.CurrentRow.Cells[2].Value.ToString();
                staffAddressL.Text = staffDb.CurrentRow.Cells[3].Value.ToString();
                staffNicL.Text = staffDb.CurrentRow.Cells[4].Value.ToString();
                //staffDobL.Value = staffDb.CurrentRow.Cells[5];
                staffTelephoneL.Text = staffDb.CurrentRow.Cells[6].Value.ToString();
                staffDepartmentL.Text = staffDb.CurrentRow.Cells[7].Value.ToString();
                staffDesignationL.Text = staffDb.CurrentRow.Cells[8].Value.ToString();
                //staffDojL.Value = staffDb.CurrentRow.Cells[9].Value.ToString();

                saveBtn.Text = "Update";
                deleteBtn.Enabled = true;
               
            }
        }

        void Reset()
        {
            staffNameL.Text = staffNameIL.Text = staffAddressL.Text = staffNicL.Text = staffTelephoneL.Text = staffDepartmentL.Text = staffDesignationL.Text = "";
            saveBtn.Text = "Save";
            eid = 0;
            deleteBtn.Enabled = false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            FillDataGridView();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            Reset();
            FillDataGridView();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                
                    SqlCommand sqlCmd = new SqlCommand("StaffDelete", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@eid", eid);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Delete successfully");
                Reset();
                FillDataGridView();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Home(), this, MDI.ActiveForm);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new staffReport(), this, MDI.ActiveForm);
        }

        private void StaffDemo_Click(object sender, EventArgs e)
        {
            staffNameL.Text = "Sumudu";
            staffNameIL.Text = "Sumudu TH0";
            staffAddressL.Text = "Galle Road, Galle";
            staffNicL.Text = "971233246V";
            staffTelephoneL.Text = "0775467648";
            staffDepartmentL.Text = "Academy";
            staffDesignationL.Text = "Teacher";
        }
    }
}
