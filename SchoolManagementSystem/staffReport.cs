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
    public partial class staffReport : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-TM7VHQ4;Initial Catalog=sms;Integrated Security=True");
        public staffReport()
        {
            InitializeComponent();
        }

        private void staffLoadBtn_Click(object sender, EventArgs e)
        {
            StaffDataSet ds = new StaffDataSet();
            SqlCommand cmd = sqlCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.StaffTableReport);
            StaffCrystalReport1 staffReport = new StaffCrystalReport1();
            staffReport.SetDataSource(ds);
            staffCrystalReportViewer1.ReportSource = staffReport;
        }

        private void staffReport_Load(object sender, EventArgs e)
        {
            if(sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
            sqlCon.Open();
        }

        private void backBtnSreport_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Staff(), this, MDI.ActiveForm);
        }
    }
}
