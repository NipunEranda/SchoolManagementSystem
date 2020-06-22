using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class employee_payments : subWindows
    {
        schoolDBDataContext obj = new schoolDBDataContext();
        private string btnStatus = "view";
        private int emp_payID;



        public employee_payments()
        {
            InitializeComponent();
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
                operation.Text = "Add Salary Details";
                MainClass.enable(panel5);
            }

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "edit";
            operation.Text = "Edit Salary Deatils";
            MainClass.enable(panel5);
            EmpIDTxt.Enabled = false;

        }
        public void loadEmpPayments()
        {
            MainClass.disable_reset(panel5);
            var dataset = obj.empPayment_get();
            emp_pay_id.DataPropertyName = "emp_payID";
            EmpID.DataPropertyName = "Emp_ID";
            EmpName.DataPropertyName = "EmpName";
            emp_datePaid.DataPropertyName = "emp_paidDate";
            emp_salary.DataPropertyName = "emp_Amount";
            EmployeeDetails.DataSource = dataset;
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            operation.Text = "View";
            btnStatus = "view";

            DialogResult dr = MessageBox.Show("Are you sure want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                obj.empPayment_delete(emp_payID);
                MainClass.showMsg(emp_payID + " Deleted successfully", "Success", "success");
                MainClass.disable_reset(panel5);
                loadEmpPayments();
            }
            else { }
        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "view";
            operation.Text = "View";
            loadEmpPayments();
            MainClass.disable_reset(panel5);
        }
  
        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void empAcceptBtn_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add" && fieldCheck() == 1)
            {
                obj.empPayment_insert((long)Convert.ToInt32(EmpIDTxt.Text), (long)Convert.ToDouble(empAmount.Text), MainClass.getDateFromString(EmpPaidDate.Text));

                MainClass.showMsg("Added Successfully.", "Success", "success");

            }
            else if (btnStatus == "edit")
            {
                obj.empPayment_edit((long)Convert.ToDouble(empAmount.Text), MainClass.getDateFromString(EmpPaidDate.Text), emp_payID);
                MainClass.showMsg("Edit Successfull.", "Success", "success");
            }
            MainClass.disable_reset(panel5);
            loadEmpPayments();
        }
        public int fieldCheck()
        {
            int status = 0;
            if (EmpIDTxt.Text == "")
            {
                MainClass.showMsg("Employee ID value cannot be empty", "Stop", "error");
            }
            else if (empAmount.Text == "")
            {
                MainClass.showMsg("Salary cannot be empty", "Stop", "error");
            }
            else if (EmpPaidDate.Text == "")
            {
                MainClass.showMsg("Date value cannot be empty", "Stop", "error");
            }
            else
                status = 1;
            return status;
        }


        private void employee_payments_Load(object sender, EventArgs e)
        {
            loadEmpPayments();
        }

        private void EmployeeDetails_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = EmployeeDetails.Rows[e.RowIndex];
                emp_payID = Convert.ToInt32(row.Cells["emp_pay_id"].Value.ToString());
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new paymentSub_window(), this, MDI.ActiveForm);
        }
    }
}
