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
    public partial class studentPayments : subWindows

    {
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-BGBH695;Initial Catalog=sms;Integrated Security=True");
        schoolDBDataContext obj = new schoolDBDataContext();
        private string btnStatus = "view";
        private int payID;

        public studentPayments()
        {
            InitializeComponent();
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
            var data = obj.studentPayments_search(Convert.ToInt32((searchTxt.Text)));
            pay_id.DataPropertyName = "payID";
            StdID.DataPropertyName = "stdID";
            StdName.DataPropertyName = "studentName";
            datePaid.DataPropertyName = "paidDate";
            stuPayment.DataPropertyName = "amount";
            StudentDetails.DataSource = data;

        }


        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "view";
            operation.Text = "View";
            loadPayments();
            MainClass.disable_reset(panel5);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add")
            {
                btnStatus = "view";
                

            }
            else if (btnStatus == "view")
            {
                btnStatus = "add";
                operation.Text = "Add Payments";
                MainClass.enable(panel5);
            }

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
           
        
                btnStatus = "edit";
                operation.Text = "Edit Payments";
                MainClass.enable(panel5);
                StdIDTxt.Enabled = false;
            

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

            operation.Text = "View";
            btnStatus = "view";

            DialogResult dr = MessageBox.Show("Are you sure want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.studentPayment_delete(payID);
                MainClass.showMsg(" Deleted successfully", "Success", "success");
                MainClass.disable_reset(panel5);
                loadPayments();
            }
            else { }

        }
        private void StdbtnPay_Click(object sender, EventArgs e)
        {
           
                if (btnStatus == "add" && fieldCheck() == 1)
                {
                    obj.studentpayment_insert((long)Convert.ToInt32(StdIDTxt.Text), (long)Convert.ToDouble(stdAmount.Text), MainClass.getDateFromString(PaidDate.Text));

                    MainClass.showMsg("Added Successfully.", "Success", "success");

                }

                else if (btnStatus == "edit")
                {
                    obj.studentPayment_edit((long)Convert.ToDouble(stdAmount.Text), MainClass.getDateFromString(PaidDate.Text), payID);
                    MainClass.showMsg("Edit Successfull.", "Success", "success");
                }
                MainClass.disable_reset(panel5);
                loadPayments();
          
        }
        

        public void loadPayments()
        {
            MainClass.disable_reset(panel5);
            var dataset = obj.studentPayment_get();
            pay_id.DataPropertyName = "payID";
            StdID.DataPropertyName = "st_ID";
            StdName.DataPropertyName = "studentName";
            datePaid.DataPropertyName = "st_paidDate";
            stuPayment.DataPropertyName = "st_Amount";
            StudentDetails.DataSource = dataset;
        }
        public int fieldCheck()
        {
            int status = 0;
            if (StdIDTxt.Text == "")
            {
                MainClass.showMsg("Student ID value cannot be empty", "Stop", "error");
            }
            else if (stdAmount.Text == "")
            {
                MainClass.showMsg("Amount value cannot be empty", "Stop", "error");
            }
            else if (payDate.Text == "")
            {
                MainClass.showMsg("Date value cannot be empty", "Stop", "error");
            }
            else
                status = 1;
            return status;
        }

        private void studentPayments_Load_1(object sender, EventArgs e)
        {
            loadPayments();
        }

        private void StudentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 )
            {
                DataGridViewRow row = StudentDetails.Rows[e.RowIndex];
                payID = Convert.ToInt32(row.Cells["pay_id"].Value.ToString());
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaidDate_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void operation_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void backBtn_Click_1(object sender, EventArgs e)
        {
            MainClass.showWindow(new paymentSub_window(), this, MDI.ActiveForm);

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
          // MainClass.showWindow(new std_payments_report(), this, MDI.ActiveForm);
        }
    }
}
