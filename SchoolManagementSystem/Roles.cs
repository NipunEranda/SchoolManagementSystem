using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Roles : subWindows
    {
        int roleId;
        string btnStatus = "";
        MainClass main = MainClass.getInstance();
        schoolDBDataContext obj = new schoolDBDataContext();
        public Roles()
        {
            InitializeComponent();
        }

        private void roleTxt_TextChanged(object sender, EventArgs e)
        {
            if (roleTxt.Text == "")
            {
                rolesErrorLabel.Visible = true;
            }
            else {
                rolesErrorLabel.Visible = false;
            }

        }

        private void statusTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusTxt.SelectedIndex == -1)
            {
                statusErrorLabel.Visible = true;
            }
            else {
                statusErrorLabel.Visible = false;
            }
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "add";
            MainClass.enable_reset(panel5);
            operation.Text = "Add Role";



        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "edit";
            operation.Text = "Edit Role";
            MainClass.enable(panel5);
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (roleTxt.Text != "")
            {
                operation.Text = "View";
                DialogResult dr = MessageBox.Show("Are you sure want to delete " + roleTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.roles_delete(roleId);
                    MainClass.showMsg(roleTxt.Text + " deleted successfully", "Success", "success");
                    MainClass.disable_reset(panel5);
                    loadRoles();
                }
                else { }
            }
            else {
                MainClass.showMsg("Select a row first", "error", "error");
            }
        }

        public void rolesSearch(String searchQuery)
        {
            MainClass.disable_reset(panel5);
            var dataSet = obj.roles_search(searchQuery);
            RolesIdGV.DataPropertyName = "ID";
            RolesGv.DataPropertyName = "Role";
            statusGv.DataPropertyName = "Status";
            rolesDGV.DataSource = dataSet;
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            rolesSearch(searchTxt.Text);
        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            btnStatus = "";
            operation.Text = "View";
            loadRoles();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            MainClass.showWindow(new Home(), this, MDI.ActiveForm);
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (roleTxt.Text == ""){
                rolesErrorLabel.Visible = true;
            }
            else
            {
                rolesErrorLabel.Visible = false;
            }

            if (statusTxt.SelectedIndex == -1)
            {
                statusErrorLabel.Visible = true;
            }
            else
            {
                statusErrorLabel.Visible = false;
            }

            if (rolesErrorLabel.Visible)
            {
                MainClass.showMsg("Roles field is empty", "error", "error");
            }
            else if (statusErrorLabel.Visible) {
                MainClass.showMsg("Status field is empty", "error", "error");
            }

            if (btnStatus == "add")
            {
                role r = new role();
                r.roleName = roleTxt.Text;
                if (statusTxt.SelectedIndex == 0)
                {
                    r.status = 1;
                }
                else {
                    r.status = 0;
                }
                if (statusTxt.SelectedIndex >= 0)
                {

                    obj.roles_insert(roleTxt.Text, r.status);
                    obj.SubmitChanges();
                    MainClass.showMsg(roleTxt.Text + " added successfully.", "Success", "success");
                    MainClass.disable_reset(panel5);
                    loadRoles();
                }
                else { }
            }
            else if (btnStatus == "edit") {
                byte stat;
                if (statusTxt.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else
                {
                    stat = 0;
                }

                obj.roles_update(roleTxt.Text, stat, roleId);
                obj.SubmitChanges();
                MainClass.showMsg(roleTxt.Text + " updated successfully", "Success", "success");
                MainClass.disable_reset(panel5);
                loadRoles();
            }
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            loadRoles();
            MainClass.disable_reset(panel5);
            adSearch.Visible = false;
        }

        public void loadRoles() {
            MainClass.disable_reset(panel5);
            MainClass.setCurrentForm(new Roles());
            MainClass.mdi.topic.Text = "Roles";
            var dataSet = obj.roles_getRoles();
            RolesIdGV.DataPropertyName = "ID";
            RolesGv.DataPropertyName = "Role";
            statusGv.DataPropertyName = "Status";
            rolesDGV.DataSource = dataSet;
        }

        private void rolesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) {
                DataGridViewRow row = rolesDGV.Rows[e.RowIndex];
                roleId = Convert.ToInt32(row.Cells["RolesIdGv"].Value.ToString());
                roleTxt.Text = row.Cells["RolesGV"].Value.ToString();
                statusTxt.SelectedItem = row.Cells["statusGV"].Value.ToString();

            }
        }
    }
}
