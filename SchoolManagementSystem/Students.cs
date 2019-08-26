using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace SchoolManagementSystem
{

    public partial class Students : subWindows
    {
        MainClass main = MainClass.getInstance();
        private int loggedId = MainClass.ROLEID;
        private string btnStatus = "view";
        private int sid;
        private int studentId;
        schoolDBDataContext obj = new schoolDBDataContext();
        Image i;
        string imagePath;

        public Students()
        {
            InitializeComponent();
        }

        public override void SearchBtn_Click(object sender, EventArgs e)
        {

            MainClass.disable_reset(panel5);
            var dataSet = obj.student_search(searchTxt.Text);
            id.DataPropertyName = "sid";
            nicId.DataPropertyName = "nic";
            fName.DataPropertyName = "firstName";
            lName.DataPropertyName = "lastName";
            birthDate.DataPropertyName = "birthdate";
            address.DataPropertyName = "address";
            telephone.DataPropertyName = "telephone";
            gender.DataPropertyName = "gender";
            grade.DataPropertyName = "grade";
            cls.DataPropertyName = "class";
            studentGridView.DataSource = dataSet;

        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel5);
            var dataSet = obj.student_search(searchTxt.Text);
            id.DataPropertyName = "sid";
            nicId.DataPropertyName = "nic";
            fName.DataPropertyName = "firstName";
            lName.DataPropertyName = "lastName";
            birthDate.DataPropertyName = "birthdate";
            address.DataPropertyName = "address";
            telephone.DataPropertyName = "telephone";
            gender.DataPropertyName = "gender";
            grade.DataPropertyName = "grade";
            cls.DataPropertyName = "class";
            studentGridView.DataSource = dataSet;
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add")
            {
                btnStatus = "view";
                operation.Text = "View Student";
                MainClass.disable(panel5);
            }
            else {
                btnStatus = "add";
                MainClass.enable_reset(panel5);
                operation.Text = "Add Student";
                acceptBtn.Visible = true;
            }
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            if (btnStatus == "edit")
            {
                btnStatus = "view";
                operation.Text = "View Student";
                MainClass.disable(panel5);
            }
            else {
                btnStatus = "edit";
                operation.Text = "Edit Student";
                MainClass.enable(panel5);
            }
        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "view";
            operation.Text = "View";
            loadStudents();
            MainClass.disable_reset(panel5);
            MainClass.enable_reset(advanceSearchPanel);
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (firstName_txt.Text != "")
            {
                operation.Text = "View";
                btnStatus = "view";

                DialogResult dr = MessageBox.Show("Are you sure want to delete " + firstName_txt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.student_delete(sid);
                    MainClass.showMsg(firstName_txt.Text + " deleted successfully", "Success", "success");
                    MainClass.disable_reset(panel5);
                    loadStudents();
                }
                else { }
            }
            else {
                MainClass.showMsg("Select a record first", "error", "error");
            }
        }

        public override void adSearch_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(advanceSearchPanel);
            advSearchPicBox.Image = Properties.Resources.user1;
            if (advanceSearchPanel.Visible == true)
                advanceSearchPanel.Visible = false;
            else
                advanceSearchPanel.Visible = true;

        }

        private void image_browse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openImage.ShowDialog();
            if (dr == DialogResult.OK) {
                i = new Bitmap(openImage.FileName);
                studentImage.Image = i;
                studentImage.SizeMode = PictureBoxSizeMode.StretchImage;
                imagePath = openImage.FileName;
            }
        }

        public void loadStudents()
        {
            MainClass.disable_reset(panel5);
            studentImage.Image = Properties.Resources.user1;
            var dataSet = obj.student_getStudent();
            id.DataPropertyName = "sid";
            nicId.DataPropertyName = "nic";
            fName.DataPropertyName = "firstName";
            lName.DataPropertyName = "lastName";
            birthDate.DataPropertyName = "birthdate";
            address.DataPropertyName = "address";
            telephone.DataPropertyName = "telephone";
            gender.DataPropertyName = "gender";
            grade.DataPropertyName = "grade";
            cls.DataPropertyName = "class";
            studentGridView.DataSource = dataSet;
        }

        public int fieldCheck()
        {
            int status = 0;
            if (firstName_txt.Text == "")
                MainClass.showMsg("First Name value cannot be empty", "Stop", "error");
            else if (lastName_txt.Text == "")
                MainClass.showMsg("Last Name value cannot be empty", "Stop", "error");
            else if (birthDay_txt.Text == "")
                MainClass.showMsg("Birthday value cannot be empty", "Stop", "error");
            else if (telephone_txt.Text == "")
                MainClass.showMsg("Telephone value cannot be empty", "Stop", "error");
            else if (address_txt.Text == "")
                MainClass.showMsg("Address value cannot be empty", "Stop", "error");
            else if (genderDropDown.SelectedIndex < 0)
                MainClass.showMsg("Gender value cannot be empty", "Stop", "error");
            else
                status = 1;
            return status;
        }

        private void FirstName_txt_TextChanged(object sender, EventArgs e)
        {
            if (firstName_txt.Text == "")
                mand_firstName.Visible = true;
            else
                mand_firstName.Visible = false;
        }

        private void LastName_txt_TextChanged(object sender, EventArgs e)
        {
            if (lastName_txt.Text == "")
                mand_lastName.Visible = true;
            else
                mand_lastName.Visible = false;
        }

        private void BirthDay_txt_ValueChanged(object sender, EventArgs e)
        {
            if (birthDay_txt.Text == "")
                mand_birthDate.Visible = true;
            else
                mand_birthDate.Visible = false;
        }

        private void Telephone_txt_TextChanged(object sender, EventArgs e)
        {
            if (telephone_txt.Text == "")
                mand_telephone.Visible = true;
            else
                mand_telephone.Visible = false;
        }

        private void Address_txt_TextChanged(object sender, EventArgs e)
        {
            if (address_txt.Text == "")
                mand_address.Visible = true;
            else
                mand_address.Visible = false;
        }

        private void Gender_txt_TextChanged(object sender, EventArgs e)
        {
            if (genderDropDown.SelectedIndex < 0)
                mand_gender.Visible = true;
            else
                mand_gender.Visible = false;
        }

        private void Students_Load(object sender, EventArgs e)
        {
            MainClass.setCurrentForm(new Students());
            MainClass.mdi.topic.Text = "Students";
            privilegesAndAttendance.Visible = true;
 //           privilegesAndAttendance.Text = "Student Attendance";
            loadStudents();
            privillegeCheck();
            loadGradesClasses();
            MainClass.setBtnVisibilityTrue(adSearch);
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (fieldCheck() == 1) {
            if (btnStatus == "add")
            {
                    student s = new student();
                    byte gender;
                    

                    if (genderDropDown.SelectedIndex == 0)
                    {
                        gender = 1;
                    }
                    else
                    {
                        gender = 0;
                    }

                    if (imagePath == "")
                    {
                        obj.student_insert_withoutImage(NIC_txt.Text, firstName_txt.Text, lastName_txt.Text, telephone_txt.Text, birthDay_txt.Value, address_txt.Text, gender, gradeDropDown.SelectedIndex + 1, classDropDown.SelectedIndex + 1);
                        MainClass.showMsg(firstName_txt.Text + " added Successfully", "Success", "success");
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        i.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        obj.student_insert(NIC_txt.Text, firstName_txt.Text, lastName_txt.Text, telephone_txt.Text, birthDay_txt.Value, address_txt.Text, gender, gradeDropDown.SelectedIndex + 1, classDropDown.SelectedIndex + 1, arr);
                        MainClass.showMsg(firstName_txt.Text + " added Successfully", "Success", "success");
                    }
                }
                else if (btnStatus == "edit") {

                    student s = new student();
                    byte gender;

                    if (genderDropDown.SelectedIndex == 0)
                        gender = 1;
                    else
                        gender = 0;

                    if (imagePath == "")
                    {
                        obj.student_update_withoutImage(NIC_txt.Text, firstName_txt.Text, lastName_txt.Text, telephone_txt.Text, birthDay_txt.Value, address_txt.Text, gender, gradeDropDown.SelectedIndex + 1, classDropDown.SelectedIndex + 1, sid);
                    }
                    else {
                        MemoryStream ms = new MemoryStream();
                        i.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        obj.student_update(NIC_txt.Text, firstName_txt.Text, lastName_txt.Text, telephone_txt.Text, birthDay_txt.Value, address_txt.Text, gender, arr, gradeDropDown.SelectedIndex + 1, classDropDown.SelectedIndex + 1, sid);
                        MainClass.showMsg(firstName_txt.Text + " updated Successfully", "Success", "success");
                    }
                }
                MainClass.disable_reset(panel5);
                loadStudents();
            }
        }


        private void studentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (advanceSearchPanel.Visible == true)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    DataGridViewRow row = studentGridView.Rows[e.RowIndex];
                    sid = Convert.ToInt32(row.Cells["id"].Value.ToString());

                    var im = (from x in obj.students where x.sid == sid select x.image).First();
                    if (im == null) { }
                    else
                    {
                        byte[] arr = im.ToArray();
                        MemoryStream ms = new MemoryStream(arr);
                        i = Image.FromStream(ms);
                        advSearchPicBox.Image = i;
                        advSearchPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }

                if (btnStatus == "view" || btnStatus == "add")
                {
                    MainClass.disable(panel5);
                }
                else
                {
                    MainClass.enable(panel5);
                }
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = studentGridView.Rows[e.RowIndex];
                sid = Convert.ToInt32(row.Cells["id"].Value.ToString());
                NIC_txt.Text = row.Cells["nicId"].Value.ToString();
                firstName_txt.Text = row.Cells["fName"].Value.ToString();
                lastName_txt.Text = row.Cells["lName"].Value.ToString();
                birthDay_txt.Text = row.Cells["birthDate"].Value.ToString();
                address_txt.Text = row.Cells["address"].Value.ToString();
                telephone_txt.Text = row.Cells["telephone"].Value.ToString();
                genderDropDown.SelectedItem = row.Cells["gender"].Value.ToString();
                gradeDropDown.SelectedItem = row.Cells["grade"].Value.ToString();
                classDropDown.SelectedItem = row.Cells["cls"].Value;

                var im = (from x in obj.students where x.sid == sid select x.image).First();
                if (im == null) { }
                else
                {
                    byte[] arr = im.ToArray();
                    MemoryStream ms = new MemoryStream(arr);
                    i = Image.FromStream(ms);
                    studentImage.Image = i;
                    studentImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }


        private void AdvanceSearch() {

            String nic = advNicTxt.Text;
            string firstName = advFnameTxt.Text;
            string lastName = advLnameTxt.Text;
            int grades = advGradeDropDown.SelectedIndex + 1;
            int classes = advClassDropDown.SelectedIndex + 1;


            if (advNicTxt.Text == "")
                nic = null;
            if (advFnameTxt.Text == "")
                firstName = null;
            if (advLnameTxt.Text == "")
                lastName = null;
            if (advSidTxt.Text != "")
                this.studentId = Convert.ToInt32(advSidTxt.Text);
            else
                this.studentId = 0;
            if (advGradeDropDown.SelectedIndex == -1)
                grades = -1;
            if (advClassDropDown.SelectedIndex == -1)
                classes = -1;

            var advanceSearch = obj.student_advanceSearch(nic, studentId, firstName, lastName, Convert.ToInt32(grades), Convert.ToInt32(classes));
            id.DataPropertyName = "sid";
            nicId.DataPropertyName = "nic";
            fName.DataPropertyName = "firstName";
            lName.DataPropertyName = "lastName";
            birthDate.DataPropertyName = "birthdate";
            address.DataPropertyName = "address";
            telephone.DataPropertyName = "telephone";
            gender.DataPropertyName = "gender";
            grade.DataPropertyName = "grade";
            cls.DataPropertyName = "class";
            studentGridView.DataSource = advanceSearch;

        }

        private void loadGradesClasses()
        {
            var grades = obj.grades_getGrades();
            foreach (var item in grades)
            {
                if (item.status == "Active")
                {
                    gradeDropDown.Items.Insert(item.gradeId - 1, item.gradeName);
                    advGradeDropDown.Items.Insert(item.gradeId - 1, item.gradeName);
                }
            }

            var classes = obj.class_getClasses();
            foreach (var item in classes) {
                if (item.status == "Active")
                {
                    classDropDown.Items.Insert(item.classId - 1, item.className);
                    advClassDropDown.Items.Insert(item.classId - 1, item.className);
                }
            }

        }

        private void advNicTxt_TextChanged(object sender, EventArgs e)
        {
            AdvanceSearch();
        }

        private void advSidTxt_TextChanged(object sender, EventArgs e)
        {
            AdvanceSearch();
        }

        private void advFnameTxt_TextChanged(object sender, EventArgs e)
        {
            AdvanceSearch();
        }

        private void advLnameTxt_TextChanged(object sender, EventArgs e)
        {
            AdvanceSearch();
        }

        private void advGradeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdvanceSearch();
            
        }

        private void advClassDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdvanceSearch();
        }

        private void gradeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gradeDropDown.SelectedIndex > 9)
            {
                NIC_txt.Enabled = true;
            }
            else {
                NIC_txt.Enabled = false;
            }
        }

        private void privilegesAndAttendance_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new StudentAttendance(), this, MDI.ActiveForm);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass.showWindow(new Home(), this, MDI.ActiveForm);
        }

        private void studentGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            advanceSearchPanel.Visible = false;
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

