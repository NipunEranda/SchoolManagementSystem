using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class Results : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-TM7VHQ4;Initial Catalog=sms;Integrated Security=True");
        SqlCommand sqlCmd;
        SqlDataAdapter sqlDa;
        DataTable dtbl;
        int ResultID;
        public Results()
        {
            InitializeComponent();
            FillDataGridView();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid()) {
                sqlCmd = new SqlCommand("insert into Result values(@sid,@subid,@mark)", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@sid",textsid.Text);
                sqlCmd.Parameters.AddWithValue("@subid", textsubid.Text);
                sqlCmd.Parameters.AddWithValue("@mark", textmark.Text);

                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
                Reset();
            }

        }

        private bool IsValid()
        {
            if(textsid.Text == string.Empty){
                MessageBox.Show("Student Name Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        void FillDataGridView()
        {
            SqlCommand sqlCmd = new SqlCommand("select * from Result", sqlCon);
            DataTable dtbl = new DataTable();
            sqlCon.Open();
            SqlDataReader sdr = sqlCmd.ExecuteReader();
            dtbl.Load(sdr);
            sqlCon.Close();
            dgvResult.DataSource = dtbl;
            dgvResult.Columns[0].Visible = false;
        }
        void Reset()
        {
            ResultID = 0;
            textsid.Clear();
            textsubid.Clear();
            textmark.Clear();
            textsid.Focus();
        }
        private void btnCansel_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResultID = Convert.ToInt32(dgvResult.SelectedRows[0].Cells[0].Value);
            textsid.Text = dgvResult.SelectedRows[0].Cells[1].Value.ToString();
            textsubid.Text = dgvResult.SelectedRows[0].Cells[2].Value.ToString();
            textmark.Text = dgvResult.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ResultID > 0)
            {
                sqlCmd = new SqlCommand("UPDATE Result SET sid=@sid,subid=@subid,mark=@mark WHERE ResultID=@ID", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@sid", textsid.Text);
                sqlCmd.Parameters.AddWithValue("@subid", textsubid.Text);
                sqlCmd.Parameters.AddWithValue("@mark", textmark.Text);
                sqlCmd.Parameters.AddWithValue("@ID", this.ResultID);

                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Update successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
                Reset();
            }
            else
            {
                MessageBox.Show("Please Select Student", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ResultID > 0)
            {
                sqlCmd = new SqlCommand("DELETE FROM Result WHERE ResultID=@ID", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID", this.ResultID);

                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Delete successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
                Reset();
            }
            else
            {
                MessageBox.Show("Please Select Student", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-V7KAUSB;Initial Catalog=$safeprojectname$;Integrated Security=True");     
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Result WHERE sid like '" + textSearch.Text+"%'", sqlCon);
            sqlDa.Fill(dtbl);
            dgvResult.DataSource = dtbl;
            
        }

    private void Results_Load(object sender, EventArgs e)
    {

    }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            Visible = false;
        }
    }
}
