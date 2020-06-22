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
    public partial class paymentSub_window : mainWindows
    {
        public paymentSub_window()
        {
            InitializeComponent();
        }



        private void std_payBtn_Click(object sender, EventArgs e)
        {
            studentPayments stdPay = new studentPayments();
            MainClass.setCurrentForm(new studentPayments());
            MainClass.showWindow(stdPay, this, MDI.ActiveForm);

        }

        private void empPay_Btn_Click(object sender, EventArgs e)
        {
            employee_payments empPay = new employee_payments();
            MainClass.setCurrentForm(new employee_payments());
            MainClass.showWindow(empPay,this,MDI.ActiveForm);

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mainlabel_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Home(), this, MDI.ActiveForm);
        }
    }
}
