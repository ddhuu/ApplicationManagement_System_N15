using System;
using System.Configuration;
using System.Data.SqlClient;

public class DBProvider
{

    private static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }


    public static SqlConnection GetOpenConnection()
    {
        var connection = new SqlConnection(GetConnectionString());
        connection.Open();
        return connection;
    }

    internal class OpenedContext : IDisposable
    {
        private SqlConnection _connection;

        public OpenedContext()
        {
            _connection = GetOpenConnection();
        }

        public SqlConnection Connection => _connection;

        public void Dispose()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}