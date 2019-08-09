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

        schoolDBDataContext obj = new schoolDBDataContext();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            loadUsers();
            adSearch.Visible = false;
            MainClass.setBtnVisibilityTrue(setPrivilleges);
            MainClass.current = new Users();
        }

        public void loadUsers()
        {
            MainClass.disable_reset(panel5);
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

    }
}
