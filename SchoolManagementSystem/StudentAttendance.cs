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

        schoolDBDataContext obj = new schoolDBDataContext();
        bool isRecorded = false;

        public StudentAttendance()
        {
            InitializeComponent();
        }

        private void StudentAttendance_Load(object sender, EventArgs e)
        {
            viewBtn.Enabled = false;
            viewBtn.Text = "VIEW REPORT";
            MainClass.setCurrentForm(new Students());
            MainClass.mdi.topic.Text = "Student Attendance";
            privilegesAndAttendance.Visible = false;
            loadGradesClasses();

            bool res = ifRecorded();
            if (res == true)
                loadStudentAttendance();
            else
                loadStudentswithoutAttendance();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Students(), this, MDI.ActiveForm);
        }

        private void loadGradesClasses()
        {
            var grades = obj.grades_getGrades();
            foreach (var item in grades)
            {
                if (item.gradeId == 1) {
                    selectGrade.Items.Insert(0, "");
                }
                if (item.status == "Active")
                {
                    selectGrade.Items.Insert(item.gradeId, item.gradeName);
                }
            }

            var classes = obj.class_getClasses();
            foreach (var item in classes)
            {
                if (item.classId == 1)
                {
                    selectClass.Items.Insert(0, "");
                }
                if (item.status == "Active")
                {
                    selectClass.Items.Insert(item.classId, item.className);
                }
            }

        }

        private void loadStudentAttendance() {

            attendDate.Format = DateTimePickerFormat.Custom;
            attendDate.CustomFormat = "yyyy-dd-MM";

                var data = obj.student_attendance_getAttendance(attendDate.Text, Convert.ToInt32((selectGrade.SelectedIndex)), Convert.ToInt32((selectClass.SelectedIndex)));
                sidGV.DataPropertyName = "sId";
                firstNameGV.DataPropertyName = "firstName";
                classGV.DataPropertyName = "className";
                gradeGV.DataPropertyName = "gradeId";
                statusGV.DataPropertyName = "status";
                dateGV.DataPropertyName = "date";
                studentAttendanceGridView.DataSource = data;

        }

        private void loadAllStudentAttendance() {
            var data = obj.student_attendance_getAllAttendance();
            sidGV.DataPropertyName = "sId";
            firstNameGV.DataPropertyName = "firstName";
            classGV.DataPropertyName = "className";
            gradeGV.DataPropertyName = "gradeId";
            statusGV.DataPropertyName = "status";
            dateGV.DataPropertyName = "date";
            studentAttendanceGridView.DataSource = data;

        }

        private void loadStudentswithoutAttendance() {
            var data = obj.student_attendance_getStudentsWithoutAttendance(attendDate.Text, Convert.ToInt32((selectGrade.SelectedIndex)), Convert.ToInt32((selectClass.SelectedIndex)));
            sidGV.DataPropertyName = "sId";
            firstNameGV.DataPropertyName = "firstName";
            classGV.DataPropertyName = "className";
            gradeGV.DataPropertyName = "gradeId";
            dateGV.DataPropertyName = "date";
            studentAttendanceGridView.DataSource = data;

        }


        private void selectGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            allSelected();
            bool res = ifRecorded();
            if (res == true)
                loadStudentAttendance();
            else
                loadStudentswithoutAttendance();
        }

        private void selectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            allSelected();
            bool res = ifRecorded();
            if (res == true)
                loadStudentAttendance();
            else
                loadStudentswithoutAttendance();
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (operationLabel.Text == "VIEW")
            {
                selectGrade.SelectedIndex = -1;
                selectClass.SelectedIndex = -1;
                var data = obj.student_attendance_getAllAttendance();
                studentAttendanceGridView.DataSource = data;
            }
            else if (operationLabel.Text == "EDIT")
            {

            }
            else if (operationLabel.Text == "ADD") {

                if (ifRecorded())
                {
                    MainClass.showMsg("Attendance already recorded for this class", "error", "error");
                }
                else {

                }
                
            }
        }

        private void attendDate_ValueChanged_1(object sender, EventArgs e)
        {
            bool res = ifRecorded();
            if (res == true)
                loadStudentAttendance();
            else
                loadStudentswithoutAttendance();

        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "ADD";
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "EDIT";
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "VIEW";
        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "VIEW";

            MainClass.showWindow(new StudentReport(attendDate.Text, selectGrade.SelectedIndex, selectClass.SelectedIndex), this, MDI.ActiveForm);
        }

        private bool ifRecorded() {
            attendDate.Format = DateTimePickerFormat.Custom;
            attendDate.CustomFormat = "yyyy-dd-MM";
            var data = obj.student_attendance_getAttendance(attendDate.Text, Convert.ToInt32((selectGrade.SelectedIndex)), Convert.ToInt32((selectClass.SelectedIndex)));
            this.isRecorded = false;
            foreach (var item in data)
            {
                if (item.status == "Absent" || item.status == "Present")
                {
                    this.isRecorded = true;
                    break;
                }
            }
            return this.isRecorded;
        }

        public bool allSelected() {
            if (selectClass.SelectedIndex > 0 && selectGrade.SelectedIndex > 0)
            {
                viewBtn.Enabled = true;
                return true;
            }
            else
            {
                viewBtn.Enabled = false;
                return false;
            }
        }

    }
}
