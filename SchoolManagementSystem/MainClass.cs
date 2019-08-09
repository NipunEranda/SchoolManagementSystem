using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SchoolManagementSystem
{
    class MainClass
    {
        public static Form current;
        private static string userName;
        private static int roleId;
        private static int teacherId;
        public static bool loginCheck = false;
        public static string appStatus = "open";
        public static MDI mdi;

        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static volatile MainClass Instance;
        schoolDBDataContext obj = new schoolDBDataContext();
        private MainClass() { }

        public static MainClass getInstance() {
            if (Instance == null)
            {
                Instance = new MainClass();
                return Instance;
            }
            else
                return Instance;
        }

        public static string USERNAME {
            get {
                return userName;
            }
            private set {
                userName = value;
            }
        }
        public static int ROLEID
        {
            get
            {
                return roleId;
            }
            private set
            {
                roleId = value;
            }
        }
        public static int TEACHERID
        {
            get
            {
                return teacherId;
            }
            private set
            {
                teacherId = value;
            }
        }

        public bool setLogin(string un, string pw)
        {
            var login = obj.systemLogin(un, pw);

            foreach (var item in login) {
                if (item.userName == null || item.roleId == null)
                {
                    loginCheck = false;
                    break;
                }
                else {
                    loginCheck = true;
                    appStatus = "logged";
                }
                USERNAME = item.userName;
                ROLEID = Convert.ToInt32(item.roleId);
            }
            return loginCheck;
        }

        public static void showWindow(Form openWindow, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWindow.WindowState = FormWindowState.Maximized;
            openWindow.MdiParent = MDI;
            openWindow.Show();
        }

        public static DialogResult showMsg(string msg, string heading, string type) {

            if (type == "success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static DialogResult checkAction(string msg, string heading)
        {
                return MessageBox.Show(msg, heading, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public static void disableButtons(Button b) {
            b.Enabled = false;
            b.BackColor = Color.LightGray;
        }

        public static void disable_reset(Panel p)
        {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;
                    text.Enabled = false;
                    text.Text = "";
                }
                if (c is ComboBox) {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton) {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (c is CheckBox) {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;
                }
                if (c is DateTimePicker) {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button) {
                    Button bt = (Button)c;
                    bt.Enabled = false;
                }
                if (c is PictureBox) {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = null;
                }
            }


        }

        public static void disable(Panel p) {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;
                    text.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                }
                if (c is Button)
                {
                    Button bt = (Button)c;
                    bt.Enabled = false;
                }
                if (c is PictureBox)
                {
                    /*PictureBox pb = (PictureBox)c;
                    pb.Image = null;*/
                }
                if (c is MonthCalendar)
                {
                    MonthCalendar mc = (MonthCalendar)c;
                    mc.Enabled = false;
                }
            }

        }

        public static void enable_reset(Panel p) {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;
                    text.Enabled = true;
                    text.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button bt = (Button)c;
                    bt.Enabled = true;
                }
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = null;
                }
                if (c is MonthCalendar)
                {
                    MonthCalendar mc = (MonthCalendar)c;
                    mc.Enabled = true;
                }
            }

        }

        public static void enable_reset(GroupBox gb) {

            foreach (Control c in gb.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;
                    text.Enabled = true;
                    text.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button bt = (Button)c;
                    bt.Enabled = true;
                }
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = null;
                }
                if (c is MonthCalendar)
                {
                    MonthCalendar mc = (MonthCalendar)c;
                    mc.Enabled = true;
                }
            }

        }

        public static void enable(Panel p) {

            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox text = (TextBox)c;
                    text.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                }
                if (c is Button)
                {
                    Button bt = (Button)c;
                    bt.Enabled = true;
                }
                if (c is MonthCalendar)
                {
                    MonthCalendar mc = (MonthCalendar)c;
                    mc.Enabled = true;
                }
            }

        }

        public static void setCurrentForm(Form form) {
            current = form;
        }

        public static Form getCurrentForm(Form form)
        {
            return current;
        }

        public DateTime getDateFromString(string date) {
            DateTime dateFromString =
                DateTime.Parse(date, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dateFromString.ToString());
            return dateFromString;
        }

        public static void setBtnVisibilityTrue(Button btn) {
            btn.Visible = true;
        }

        public static void setMDI(MDI m) {
            mdi = m;
        }

    }
}
