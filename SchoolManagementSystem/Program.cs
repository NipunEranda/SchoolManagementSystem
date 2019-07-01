using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MySqlConnection con = DbConnection.getConnectionObj();
            Login loginInstance = new Login(con);
            Application.Run(loginInstance);
            if (loginInstance.getStatus())
                Application.Run(new MDI(con));
        }
    }
}
