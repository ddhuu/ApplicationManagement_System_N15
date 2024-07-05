using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class DBProvider
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


    internal class OpenedContext : IDisposable
    {
        private SqlConnection _connection;

        public OpenedContext()
        {
            _connection = lazyConnection.Value;
            if (_connection.State != System.Data.ConnectionState.Open) _connection.Open();
        }

        public void Dispose()
        {
            if (_connection.State != System.Data.ConnectionState.Closed) _connection.Close();
        }

    }

    ~DBProvider()
    {
        lazyConnection.Value.Dispose();
    }
}