using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Settings : mainWindows
    {
        MainClass main = MainClass.getInstance();
        public string status = "";
        public Settings()
        {
            InitializeComponent();
        }

        private void SettingSaveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (integratedCheck.Checked)
            {
                sb.Append("Data Source=" + dataSourceTxt.Text + ";Initial Catalog=" + dataBaseTxt.Text + ";Integrated Security=true;MultipleActiveResultSets=true");
                File.WriteAllText(MainClass.path + "\\cnt", sb.ToString());
                DialogResult dr = MessageBox.Show("setting saved succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    status = "ok";
                    this.Close();
                    Login login = new Login();
                    login.Show();
                }
            }
            else {
                sb.Append("Data Source=" + dataSourceTxt.Text + ";Initial Catalog=" + dataBaseTxt.Text + ";User ID=" + userNameTxt.Text + ";Password=" + passwordTxt.Text + ";MultipleActiveResultSets=true");
                File.WriteAllText(MainClass.path+"\\cnt", sb.ToString());
                DialogResult dr = MessageBox.Show("setting saved succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    status = "ok";
                    this.Close();
                    Login login = new Login();
                    login.Show();
                }
            }
        }

        private void integratedCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (integratedCheck.Checked)
            {
                userNameTxt.Text = "";
                userNameTxt.Enabled = false;

                passwordTxt.Text = "";
                passwordTxt.Enabled = false;
            }
            else {

                userNameTxt.Enabled = true;
                passwordTxt.Enabled = true;

            }
        }
    }
}
