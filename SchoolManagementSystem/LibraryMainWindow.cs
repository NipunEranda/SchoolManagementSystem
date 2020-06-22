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
    public partial class LibraryMainWindow : Form
    {
        public LibraryMainWindow()
        {
            InitializeComponent();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new LibraryManagementSystem(), this, MDI.ActiveForm);
        }
        public virtual void lblSearch_Click(object sender, EventArgs e)
        {

        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnView_Click(object sender, EventArgs e)
        {

        }

        
    }
}
