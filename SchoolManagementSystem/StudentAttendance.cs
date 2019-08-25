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
    public partial class StudentAttendance : subWindows
    {
        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            MainClass.setCurrentForm(new Students());
            MainClass.mdi.topic.Text = "Student Attendance";
            privilegesAndAttendance.Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Students(), this, MDI.ActiveForm);
        }
    }
}
