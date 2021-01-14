using MySqlConnector;
using System;

namespace TLECoreAPI
{
    public class AppDb : IDisposable
    {
        public MySqlConnection Connection { get; private set; }

        public AppDb(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }

        public void Dispose() => Connection.Dispose();
    }
}
