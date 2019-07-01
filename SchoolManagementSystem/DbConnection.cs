using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SchoolManagementSystem
{
    class DbConnection
    {

        public static volatile MySqlConnection Instance;

        private DbConnection() { }

        public static MySqlConnection getConnectionObj()
        {

            if (Instance == null)
            {
                string myConnection = "datasource=localhost;port=3306;database=SMS;username=root;password=4212";
                Instance = new MySqlConnection(myConnection);
                return Instance;
            }

            return Instance;

        }

    }
}
