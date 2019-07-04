using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    class MainClass
    {

        public static volatile MainClass Instance;
        private MySqlConnection con = DbConnection.getConnection();
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

        public void showWindow(Form openWindow, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWindow.WindowState = FormWindowState.Maximized;
            openWindow.MdiParent = MDI;
            openWindow.Show();
        }

        public DateTime getDateFromString(string date) {
            DateTime dateFromString =
                DateTime.Parse(date, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dateFromString.ToString());
            return dateFromString;
        }

        public int getSID()
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
        }

    }
}
