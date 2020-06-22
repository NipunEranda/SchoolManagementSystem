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
            do
            {
                if (MainClass.appStatus == "" || MainClass.appStatus == "open")
                {
                    Login loginInstance = new Login();
                    MainClass main = MainClass.getInstance();
                    if (!File.Exists(MainClass.path + "\\cnt"))
                    {
                        Settings settings = new Settings();
                        Application.Run(settings);
                        if(settings.status == "")
                        break;
                    }
                    else
                    {
                        Application.Run(loginInstance);
                        if (loginInstance.getStatus())
                        {
                            MDI mdi = new MDI();
                            MainClass.setMDI(mdi);
                            Application.Run(mdi);
                        }
                        if (MainClass.appStatus == "exit")
                            break;
                    }
                }
            } while (MainClass.appStatus != null);
        }
    }
}
