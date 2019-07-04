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
        public static volatile MySqlConnection tempInstance;

        private DbConnection() { }

        public static MySqlConnection getConnection()
        {

            if (Instance == null)
            {
                string myConnection = "datasource=localhost;port=3306;database=SMS;username=root;password=4212;Convert Zero Datetime=True";
                Instance = new MySqlConnection(myConnection);
                return Instance;
            }

            return Instance;

        }

        public static MySqlConnection getTempConnection() {
            if (tempInstance == null) {
                string myConnection = "datasource=localhost;port=3306;database=tmp;username=root;password=4212";
                tempInstance = new MySqlConnection(myConnection);
                return tempInstance;
            }

            return tempInstance;
        }

    }
}
