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

        public void showWindow(Form openWindow, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWindow.WindowState = FormWindowState.Maximized;
            openWindow.MdiParent = MDI;
            openWindow.Show();
        }

    }
}
