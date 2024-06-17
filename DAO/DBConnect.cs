using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DBConnect : IDisposable
    {
        private static Lazy<SqlConnection> lazyConnection = new Lazy<SqlConnection>(() =>
            new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString));

        public static SqlConnection GetOpenConnection()
        {
            var connection = lazyConnection.Value;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

        public void Dispose()
        {
            if (lazyConnection.IsValueCreated)
            {
                lazyConnection.Value.Dispose();
            }
        }
    }
}