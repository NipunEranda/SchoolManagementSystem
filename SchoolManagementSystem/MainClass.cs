using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    class MainClass
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static volatile MainClass Instance;
        private SqlConnection con = DbConnection.getConnection();
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
                    PictureBox pb = (PictureBox)c;
                    pb.Image = null;
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

        public DateTime getDateFromString(string date) {
            DateTime dateFromString =
                DateTime.Parse(date, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dateFromString.ToString());
            return dateFromString;
        }

        /*public int getSID()
        {
            int sid = 0;
            con.Open();
            string getSID = "select * from student";
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(getSID, con);
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                sid = dataTable.Rows.Count;
                ++sid;
            }
            else if (dataTable.Rows.Count == 0)
            {
                sid = 1;
            }
            con.Close();
            return sid;
        }*/

    }
}
