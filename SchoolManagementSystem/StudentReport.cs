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
    public partial class StudentReport : Form
    {
        schoolDBDataContext obj = new schoolDBDataContext();
        String a_date;
        int classId;
        int gradeId;
        public StudentReport(String a_date, int gradeId, int classId)
        {
            this.gradeId = gradeId;
            this.classId = classId;
            this.a_date = a_date;
            InitializeComponent();
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = obj.student_attendance_getDailyAttendance_report(a_date, gradeId, classId);
            this.reportViewer1.RefreshReport();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new StudentAttendance(), this, MDI.ActiveForm);
        }
    }
}
