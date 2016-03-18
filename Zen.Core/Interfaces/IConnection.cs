using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IConnection : IDisposable
    {
        string ConnectionName { get; set; }
        void OpenPool(string hostname, string databaseName, Orient.Client.ODatabaseType databaseType, string username, string password);
        void OpenPool(string hostname, int port, string databaseName, Orient.Client.ODatabaseType databaseType, string username, string password);
        void ClosePool();
    }
}
