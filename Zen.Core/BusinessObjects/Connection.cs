using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orient.Client;
using Zen.Core.Interfaces;

namespace Zen.Core.BusinessObjects
{
    public class Connection : IConnection
    {
        private readonly int DEFAULT_POOL_SIZE = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("DefaultConnectionPoolSize"));
        private readonly int DEFAULT_PORT = int.Parse(System.Configuration.ConfigurationManager.AppSettings.Get("DefaultConnectionPoolSize"));

        private IZClient _client;
        public Connection(IZClient client)
        {
            _client = client;
        }

        public void OpenPool(string hostname, int port, string databaseName, ODatabaseType databaseType, string username, string password, string alias)
        {
            _client.CreateDatabasePool(hostname, port, databaseName, databaseType, username, password, DEFAULT_POOL_SIZE, alias);
        }

        public void ClosePool(string alias)
        {
            _client.DropDatabasePool(alias);
        }

        public void OpenPool(string hostname, string databaseName, ODatabaseType databaseType, string username, string password, string alias)
        {
            _client.CreateDatabasePool(hostname, DEFAULT_PORT, databaseName, databaseType, username, password, DEFAULT_POOL_SIZE, alias);
        }
    }
}
