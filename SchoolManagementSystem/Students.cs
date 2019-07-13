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

        private string btnStatus = "view";
        int sid;

        MainClass main = MainClass.getInstance();
        schoolDBDataContext obj = new schoolDBDataContext();
        Image i;

        public Students()
        {
            InitializeComponent();
        }

        public override void SearchBtn_Click_1(object sender, EventArgs e)
        {

            MainClass.disable_reset(panel5);
            var dataSet = obj.student_search(searchTxt.Text);
            id.DataPropertyName = "SID";
            nicId.DataPropertyName = "NIC";
            fName.DataPropertyName = "FNAME";
            lName.DataPropertyName = "LNAME";
            birthDate.DataPropertyName = "BIRTHDATE";
            address.DataPropertyName = "ADDRESS";
            telephone.DataPropertyName = "TELEPHONE";
            gender.DataPropertyName = "GENDER";
            studentGridView.DataSource = dataSet;

        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "add";
            MainClass.enable_reset(panel5);
            operation.Text = "Add Student";
            acceptBtn.Visible = true;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "edit";
            operation.Text = "Edit Student";
            MainClass.enable(panel5);
        }

        public override void ViewBtn_Click_1(object sender, EventArgs e)
        {
            btnStatus = "view";
            operation.Text = "View";
            loadStudents();
            MainClass.disable_reset(panel5);
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
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

        private void image_browse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openImage.ShowDialog();
            if (dr == DialogResult.OK) {
                i = new Bitmap(openImage.FileName);
                studentImage.Image = i;
                studentImage.SizeMode = PictureBoxSizeMode.StretchImage;
                imagePath.Text = openImage.FileName;
            }
        }

        public void loadStudents()
        {
            MainClass.disable_reset(panel5);
            var dataSet = obj.student_getStudent();
            id.DataPropertyName = "sid";
            nicId.DataPropertyName = "nic";
            fName.DataPropertyName = "firstName";
            lName.DataPropertyName = "lastName";
            birthDate.DataPropertyName = "birthdate";
            address.DataPropertyName = "address";
            telephone.DataPropertyName = "telephone";
            gender.DataPropertyName = "gender";
            studentGridView.DataSource = dataSet;
        }

        public void searchStudents(string name) {

        }

        public int fieldCheck()
        {
            int status = 0;
            if (NIC_txt.Text == "")
                MainClass.showMsg("NIC value cannot be empty", "Stop", "error");
            else if (firstName_txt.Text == "")
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

        private void NIC_txt_TextChanged(object sender, EventArgs e)
        {
            if (NIC_txt.Text == "")
                mand_nic.Visible = true;
            else
                mand_nic.Visible = false;
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
            loadStudents();    
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
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

                if (imagePath.Text == "")
                {
                    obj.student_insert_withoutImage(NIC_txt.Text, firstName_txt.Text, lastName_txt.Text, telephone_txt.Text, birthDay_txt.Value, address_txt.Text, gender);
                    MainClass.showMsg(firstName_txt.Text + " added Successfully", "Success", "success");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    i.Save(ms, ImageFormat.Jpeg);
                    byte[] arr = ms.ToArray();
                    obj.student_insert(NIC_txt.Text, firstName_txt.Text, lastName_txt.Text, telephone_txt.Text, birthDay_txt.Value, address_txt.Text, gender, arr);
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

                if (imagePath.Text == "")
                {
                    obj.student_update_withoutImage(NIC_txt.Text, firstName_txt.Text, lastName_txt.Text, telephone_txt.Text, birthDay_txt.Value, address_txt.Text, gender, sid);
                }
                else {
                    MemoryStream ms = new MemoryStream();
                    i.Save(ms, ImageFormat.Jpeg);
                    byte[] arr = ms.ToArray();
                    obj.student_update(NIC_txt.Text, firstName_txt.Text, lastName_txt.Text, telephone_txt.Text, birthDay_txt.Value, address_txt.Text, gender, arr, sid);
                    MainClass.showMsg(firstName_txt.Text + " updated Successfully", "Success", "success");
                }
            }
            MainClass.disable_reset(panel5);
            loadStudents();
        }



        private void studentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnStatus == "view" || btnStatus == "add")
            {
                MainClass.disable(panel5);
            }
            else {
                MainClass.enable(panel5);
            }
            if (e.RowIndex != -1 && e.ColumnIndex != -1) {
                DataGridViewRow row = studentGridView.Rows[e.RowIndex];
                sid = Convert.ToInt32(row.Cells["id"].Value.ToString());
                NIC_txt.Text = row.Cells["nicId"].Value.ToString();
                firstName_txt.Text = row.Cells["fName"].Value.ToString();
                lastName_txt.Text = row.Cells["lName"].Value.ToString();
                address_txt.Text = row.Cells["address"].Value.ToString();
                telephone_txt.Text = row.Cells["telephone"].Value.ToString();
                genderDropDown.SelectedItem = row.Cells["gender"].Value.ToString();

                var im = (from x in obj.students where x.sid == sid select x.image).First();
                if (im == null) { }
                else {
                    byte[] arr = im.ToArray();
                    MemoryStream ms = new MemoryStream(arr);
                    i = Image.FromStream(ms);
                    studentImage.Image = i;
                    studentImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
    }

