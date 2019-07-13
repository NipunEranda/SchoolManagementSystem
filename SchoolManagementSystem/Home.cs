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
    public partial class Home : mainWindows
    {
        
        MainClass main = MainClass.getInstance();
        Students students = new Students();

        public Home()
        {
            InitializeComponent();
        }

        private void stdBtn_Click(object sender, EventArgs e)
        {
            
            MainClass.showWindow(students, this, MDI.ActiveForm);
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {

        }

        private void classesBtn_Click(object sender, EventArgs e)
        {

        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {

        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {

        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {

        }

        private void paymentsBtn_Click(object sender, EventArgs e)
        {

        }

        private void timeTablesBtn_Click(object sender, EventArgs e)
        {

        }

        private void examBtn_Click(object sender, EventArgs e)
        {

        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            Roles role = new Roles();
            MainClass.showWindow(role, this, MDI.ActiveForm);
        }
    }
}
