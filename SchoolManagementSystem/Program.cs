using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

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
            MDI mdi = new MDI();
            Login loginInstance = new Login();
            MainClass main = MainClass.getInstance();
            if (File.Exists(MainClass.path + "\\cnt"))
            {
                Application.Run(loginInstance);
                if (loginInstance.getStatus())
                    Application.Run(new MDI());
            }
            else {
                Settings settings = new Settings();
                Application.Run(settings);
                if (settings.status == "ok") {
                    Application.Run(loginInstance);
                    if (loginInstance.getStatus())
                        Application.Run(new MDI());
                }
            }
        }
    }
}
