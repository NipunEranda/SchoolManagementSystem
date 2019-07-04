using System;
using System.Collections.Generic;
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


    }
}
