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
        MainClass main = MainClass.getInstance();
        public subWindows()
        {
            InitializeComponent();
        }

        public void backBtn_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            MainClass.showWindow(home, this, MDI.ActiveForm);
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

        public virtual void SearchBtn_Click_1(object sender, EventArgs e)
        {

        }

        public virtual void ViewBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
