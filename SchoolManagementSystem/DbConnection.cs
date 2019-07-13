using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    class DbConnection
    {

        public static volatile SqlConnection Instance;

        private DbConnection() { }

        public static SqlConnection getConnection()
        {

            if (Instance == null)
            {
                string myConnection = "datasource=DESKTOP-TM7VHQ4;Initial Catalog=sms;Integrated Security=true;MultipleActiveResultSets=true";
               /* Instance = new SqlConnection(myConnection);*/
                return Instance;
            }

            return Instance;

        }

    }
}
