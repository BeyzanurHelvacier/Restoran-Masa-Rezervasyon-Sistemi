using System.Configuration;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public static class DbHelper
    {
        public static MySqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            return new MySqlConnection(connStr);

        }
    }
}
