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
    public partial class Users : subWindows
    {

        int userID = 0;

        schoolDBDataContext obj = new schoolDBDataContext();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            loadUsers();
            loadRoles();
            adSearch.Visible = false;
            MainClass.setBtnVisibilityTrue(privilegesAndAttendance);
            MainClass.current = new Users();
        }

        public void loadUsers()
        {
            MainClass.disable_reset(panel5);
            MainClass.setCurrentForm(new Users());
            MainClass.mdi.topic.Text = "Users";
            var dataSet = obj.users_viewUsers();
            userId.DataPropertyName = "userId";
            userName.DataPropertyName = "userName";
            roleId.DataPropertyName = "roleId";
            usersGridView.DataSource = dataSet;
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            usersSearch(searchTxt.Text);
        }
        public void usersSearch(String searchQuery)
        {
            MainClass.disable_reset(panel5);
            var dataSet = obj.users_search(searchQuery);
            userId.DataPropertyName = "Id";
            userName.DataPropertyName = "User";
            roleId.DataPropertyName = "roleId";
            usersGridView.DataSource = dataSet;
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            if (passwordChangePanel.Visible == true)
                passwordChangePanel.Visible = false;

            MainClass.enable_reset(panel5);
            if (addUserPanel.Visible == false)
            {
                addUserPanel.Visible = true;
            }
            else
            {
                addUserPanel.Visible = false;
            }
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

            if (operationTxt.Text != "Edit")
            {
                operationTxt.Text = "Edit";
                MainClass.enable(panel5);
            }
            else
            {
                operationTxt.Text = "View";
                MainClass.disable(panel5);
            }

        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {

            if (operationTxt.Text != "View")
            {
                operationTxt.Text = "View";
                MainClass.disable(panel5);
                userAddBtn.Visible = false;
            }
            else { }
            MainClass.disable_reset(panel5);
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

            if (userNameTxt.Text != "")
            {
                operationTxt.Text = "View";
                DialogResult dr = MessageBox.Show("Are you sure want to delete " + userNameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.users_deleteUser(userID);
                    MainClass.showMsg(userNameTxt.Text + " deleted successfully", "Success", "success");
                    MainClass.disable_reset(panel5);
                    loadUsers();
                }
                else { }
            }
            else
            {
                MainClass.showMsg("Select a row first", "Error", "Error");
            }

        }

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (operationTxt.Text == "View" || operationTxt.Text == "Add")
            {
                MainClass.disable(panel5);
            }
            else
            {
                MainClass.enable(panel5);
            }

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = usersGridView.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userId"].Value.ToString());
                userNameTxt.Text = row.Cells["userName"].Value.ToString();
                rolesDropDown.Text = row.Cells["roleId"].Value.ToString();
            }


        }

        private void actionBtn_Click(object sender, EventArgs e)
        {

        }

        public void loadRoles() {
            var roles = obj.roles_getRoles();
            foreach (var item in roles)
            {
                if (item.Status == "Active")
                {
                    rolesDropDown.Items.Insert(item.ID - 1, item.Role);
                    roleIdDropDown.Items.Insert(item.ID - 1, item.Role);
                }
            }
        }

        private void userAddBtn_Click(object sender, EventArgs e)
        {
            if (uName.Text == "")
                MainClass.showMsg("Username cannot be empty!", "Error", "error");
            else if (roleIdDropDown.SelectedIndex == -1)
                MainClass.showMsg("Role name cannot be empty!", "Error", "error");
            else if (userPass.Text == "")
                MainClass.showMsg("Password cannot be empty!", "Error", "error");
            else if (userConPass.Text == "")
                MainClass.showMsg("Confirm the password!", "Error", "error");
            else if (userConPass.Text != userPass.Text)
                MainClass.showMsg("Passwords doesn't match!", "Error", "error");
            else{
                obj.users_insert(uName.Text, userPass.Text, roleIdDropDown.SelectedIndex + 1);
                obj.SubmitChanges();
                MainClass.showMsg(uName.Text + " added successfully.", "Success", "success");
                MainClass.disable_reset(panel5);
                loadUsers();
            }
        }

        private void changePassPanelV_Click(object sender, EventArgs e)
        {
            if (userID != 0)
            {
                if (passwordChangePanel.Visible == false)
                    passwordChangePanel.Visible = true;
                else
                    passwordChangePanel.Visible = false;
            }
            else
                MainClass.showMsg("Select a record first!", "Error", "Error");
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (changeUserPassword())
            {
                if (userID == 1)
                {
                    MainClass.showMsg("Password Changed Successfully, Logging out for changes!", "Success", "success");
                    MainClass.appStatus = "";
                    MainClass.immediateLogoutOn();
                    MainClass.closeMDI();
                }
                else {
                    MainClass.showMsg("Password Changed Successfully!", "Success", "success");
                    MainClass.enable_reset(passwordChangePanel);
                }
            }
            else {
                MainClass.showMsg("Current Password doesn't match!", "Error", "Error");
            }
        }

        public Boolean changeUserPassword() {
            if (currentPassword.Text == "")
                MainClass.showMsg("Enter the current password!", "Error", "Error");
            else if (newPassword.Text == "")
                MainClass.showMsg("Enter the new password!", "Error", "Error");
            else if (confirmNewPassword.Text == "")
                MainClass.showMsg("Confirm the new password!", "Error", "Error");
            else if (newPassword.Text != confirmNewPassword.Text)
                MainClass.showMsg("Passwords doesn't match!", "Error", "Error");
            else
            {
                var change = obj.users_changePassword(userID, currentPassword.Text, newPassword.Text);
                obj.SubmitChanges();

                foreach (var item in change)
                {
                    if (item.changedId == userID)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            MainClass.showWindow(new Home(), this, MDI.ActiveForm);
        }
    }
}
