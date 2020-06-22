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
    public partial class LibraryManagementSystem : mainWindows
    {
        public LibraryManagementSystem()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Home(), this, MDI.ActiveForm);
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new addBooks(), this, MDI.ActiveForm);
        }

        private void btnAddMembers_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new addMembers(), this, MDI.ActiveForm);
        }

        private void btnReserveBooks_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new reserveBooks(), this, MDI.ActiveForm);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new returnBooks(), this, MDI.ActiveForm);
        }

        private void btnOverDuePayments_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new libraryOverDuePayments(), this, MDI.ActiveForm);
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new checkAvailability(), this, MDI.ActiveForm);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //MainClass.showWindow(new libraryReport(), this, MDI.ActiveForm);
        }      
    }
}
