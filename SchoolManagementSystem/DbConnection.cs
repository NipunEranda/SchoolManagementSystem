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

        public static volatile MySqlConnection conInstance;

        private DbConnection() { }

        public static MySqlConnection getConnectionObj()
        {

            if (conInstance == null)
            {
                string myConnection = "datasource=localhost;port=3306;database=SMS;username=root;password=4212";
                conInstance = new MySqlConnection(myConnection);
                return conInstance;
            }

            return conInstance;

        }

    }
}
