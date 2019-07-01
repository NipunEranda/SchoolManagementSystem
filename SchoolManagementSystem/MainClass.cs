using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    class MainClass
    {

        public static volatile MainClass Instance;
        private MainClass() { }

        public void showWindow(Form openWindow, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWindow.WindowState = FormWindowState.Maximized;
            openWindow.MdiParent = MDI;
            openWindow.Show();
        }

        public static MainClass getInstance() {
            if (Instance == null)
            {
                Instance = new MainClass();
                return Instance;
            }
            else
                return Instance;
        }

    }
}
