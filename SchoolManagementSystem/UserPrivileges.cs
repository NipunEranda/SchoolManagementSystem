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

    public partial class UserPrivileges : subWindows
    {

        private static Form Previous = null;
        public UserPrivileges()
        {
            InitializeComponent();
        }

        private void UserPrivileges_Load(object sender, EventArgs e)
        {
            MainClass.setCurrentForm(new UserPrivileges());
            MainClass.mdi.topic.Text = "User Privileges";
        }

        private void setPrivilleges_Click_1(object sender, EventArgs e)
        {

        }

        public void setPrevious(Form form) {
            Previous = form;
        }

        public Form getPrevious() {
            return Previous;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Users(), this, MDI.ActiveForm);
        }
    }
}
