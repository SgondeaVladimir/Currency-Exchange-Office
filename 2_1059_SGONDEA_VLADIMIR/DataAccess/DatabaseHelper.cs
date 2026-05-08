using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1059_SGONDEA_VLADIMIR.DataAccess
{
    public static class DatabaseHelper
    {
        // Connection String 
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ExchangeDB.mdf;Integrated Security=True";

        // Aceasta metoda ne va returna o conexiune gata de a fi deschisa
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
