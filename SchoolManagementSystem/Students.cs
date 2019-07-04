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

namespace SchoolManagementSystem
{

    public partial class Students : subWindows
    {

        private string btnStatus = "";
        private int edit = 0;

        private MySqlConnection con = DbConnection.getConnection();
        MainClass main = MainClass.getInstance();

        public Students()
        {
            InitializeComponent();
        }

        public override void SearchBtn_Click_1(object sender, EventArgs e)
        {
            
            searchStudents(searchTxt.Text);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "add";
            clearFields();
            submit.Visible = true;
            operation.Text = "Add Student";

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "edit";
            edit = 1;
            submit.Visible = true;
            operation.Text = "Edit Student";
            viewStudents();
        }

        public override void ViewBtn_Click_1(object sender, EventArgs e)
        {
            btnStatus = "save";
            edit = 0;
            operation.Text = "View";
            loadStudents();
            viewStudents();
            submit.Visible = false;
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            operation.Text = "View";
            btnStatus = "delete";

            DialogResult result = MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                try
                {
                    int deleteRowIndex = studentGridView.CurrentCell.RowIndex;
                    string deleteRecord = "delete from student where sid = " + (studentGridView.Rows[deleteRowIndex].Cells[0].Value);
                    MySqlCommand command = new MySqlCommand(deleteRecord, con);
                    MySqlDataReader reader;
                    con.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read()) { }
                    con.Close();
                    loadStudents();
                    clearFields();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Empty Dataset");
                }
            }
            else
            {
            }

            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (btnStatus == "add") {
                int status = fieldCheck();
                if (status == 1)
                {
                    DialogResult result = MessageBox.Show("Do you want to Add?", "Add the student", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        string insertStudent = "insert into student values(" + main.getSID() + ", '" + NIC_txt.Text + "', '" + firstName_txt.Text + "', '" + lastName_txt.Text + "', '" + telephone_txt.Text + "', '" + birthDay_txt.Text + "', '" + address_txt.Text + "', '" + gender_txt.Text + "')";
                        MySqlDataAdapter sqlDA = new MySqlDataAdapter(insertStudent, con);
                        DataTable DataTable = new DataTable();
                        sqlDA.Fill(DataTable);

                        if (DataTable.Rows.Count == 0)
                        {
                            clearFields();
                            loadStudents();
                        }
                        else
                        {
                            loadStudents();
                        }
                    }
                    else { }
                }
                else
                {
                }
            }
            else if (btnStatus == "edit") {

                int status = fieldCheck();
                if (status == 1)
                {
                    string updateRecord = "update student set NIC = '" + NIC_txt.Text + "', firstName = '" + firstName_txt.Text + "', lastName = '" + lastName_txt.Text + "', telephone = '" + telephone_txt.Text + "', birthDate = '" + birthDay_txt.Text + "', address = '" + address_txt.Text + "', gender = '" + gender_txt.Text + "' where sid = " + studentGridView.Rows[studentGridView.CurrentCell.RowIndex].Cells[0].Value;
                    MySqlCommand command = new MySqlCommand(updateRecord, con);
                    MySqlDataReader reader;
                    con.Open();
                    reader = command.ExecuteReader();
                    while (reader.Read()) { }
                    con.Close();
                    loadStudents();
                    clearFields();
                }
                else { }

            }
        }

        public void loadStudents()
        {
            con.Open();
            string students_set = "select * from student order by sid ASC";
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(students_set, con);
            DataTable DataTable = new DataTable();
            sqlDA.Fill(DataTable);
            if (DataTable.Rows.Count > 0)
                studentGridView.DataSource = DataTable;
            else
            {

            }
            con.Close();
        }

        public void searchStudents(string name) {
            con.Open();
            string searchStudent = "select * from student where firstName LIKE '%" + name + "%' or lastName LIKE '%" + name + "%'";
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(searchStudent, con);
            DataTable DataTable = new DataTable();
            sqlDA.Fill(DataTable);
            if (DataTable.Rows.Count > 0)
                studentGridView.DataSource = DataTable;
            else
            {

            }
            con.Close();
        }

        public void clearFields()
        {
            NIC_txt.Text = "";
            firstName_txt.Text = "";
            lastName_txt.Text = "";
            telephone_txt.Text = "";
            address_txt.Text = "";
            gender_txt.Text = "";
            mand_nic.Visible = false;
            mand_address.Visible = false;
            mand_birthDate.Visible = false;
            mand_firstName.Visible = false;
            mand_lastName.Visible = false;
            mand_gender.Visible = false;
            mand_telephone.Visible = false;
        }

        public int fieldCheck()
        {
            int status = 0;
            if (NIC_txt.Text == "")
                MessageBox.Show("NIC value cannot be empty");
            else if (firstName_txt.Text == "")
                MessageBox.Show("First Name value cannot be empty");
            else if (lastName_txt.Text == "")
                MessageBox.Show("Last Name value cannot be empty");
            else if (birthDay_txt.Text == "")
                MessageBox.Show("Birthday value cannot be empty");
            else if (telephone_txt.Text == "")
                MessageBox.Show("Telephone value cannot be empty");
            else if (address_txt.Text == "")
                MessageBox.Show("Address value cannot be empty");
            else if (gender_txt.Text == "")
                MessageBox.Show("Gender value cannot be empty");
            else
                status = 1;
            return status;
        }

        public void viewStudents()
        {

            try
            {
                int viewRowIndex = studentGridView.CurrentCell.RowIndex;
                NIC_txt.Text = studentGridView.Rows[viewRowIndex].Cells[1].Value.ToString();
                firstName_txt.Text = studentGridView.Rows[viewRowIndex].Cells[2].Value.ToString();
                lastName_txt.Text = studentGridView.Rows[viewRowIndex].Cells[3].Value.ToString();
                telephone_txt.Text = studentGridView.Rows[viewRowIndex].Cells[4].Value.ToString();
                birthDay_txt.Value = main.getDateFromString(studentGridView.Rows[viewRowIndex].Cells[5].Value.ToString());
                address_txt.Text = studentGridView.Rows[viewRowIndex].Cells[6].Value.ToString();
                gender_txt.Text = studentGridView.Rows[viewRowIndex].Cells[7].Value.ToString();

            }
            catch (NullReferenceException)
            {

            }
        }

        private void NIC_txt_TextChanged(object sender, EventArgs e)
        {
            if (NIC_txt.Text == "")
                mand_nic.Visible = true;
        }

        private void FirstName_txt_TextChanged(object sender, EventArgs e)
        {
            if (firstName_txt.Text == "")
                mand_firstName.Visible = true;
        }

        private void LastName_txt_TextChanged(object sender, EventArgs e)
        {
            if (lastName_txt.Text == "")
                mand_lastName.Visible = true;
        }

        private void BirthDay_txt_ValueChanged(object sender, EventArgs e)
        {
            if (birthDay_txt.Text == "")
                mand_birthDate.Visible = true;
        }

        private void Telephone_txt_TextChanged(object sender, EventArgs e)
        {
            if (telephone_txt.Text == "")
                mand_telephone.Visible = true;
        }

        private void Address_txt_TextChanged(object sender, EventArgs e)
        {
            if (address_txt.Text == "")
                mand_address.Visible = true;
        }

        private void Gender_txt_TextChanged(object sender, EventArgs e)
        {
            if (gender_txt.Text == "")
                mand_gender.Visible = true;
        }

        private void Students_Load(object sender, EventArgs e)
        {
            loadStudents();
            viewStudents();
        }
    }
}
