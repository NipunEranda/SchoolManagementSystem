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
    public partial class subWindows : mainWindows
    {
        private int loggedId = MainClass.ROLEID;
        MainClass main = MainClass.getInstance();
        schoolDBDataContext obj = new schoolDBDataContext();
        public subWindows()
        {
            InitializeComponent();
        }

        public virtual void addBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void ViewBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void adSearch_Click(object sender, EventArgs e)
        {

        }

        public virtual void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void setPrivilleges_Click(object sender, EventArgs e)
        {
            UserPrivileges up = new UserPrivileges();
            MainClass.setCurrentForm(new UserPrivileges());
            MainClass.showWindow(up, this, MDI.ActiveForm);
        }

        private void subWindows_Load(object sender, EventArgs e)
        {
            privillegeCheck();
        }

        public void privillegeCheck()
        {

            var privileges = obj.privileges_getPrivileges(Convert.ToByte(loggedId));
            foreach (var item in privileges)
            {
                if (item.studAdd == 0)
                    addBtn.Enabled = false;
                if (item.studDelete == 0)
                    deleteBtn.Enabled = false;
                if (item.studEdit == 0)
                    editBtn.Enabled = false;
            }
        }

    }
}
