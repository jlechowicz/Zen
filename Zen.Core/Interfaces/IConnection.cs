using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IConnection
    {
        void OpenPool(string hostname, string databaseName, Orient.Client.ODatabaseType databaseType, string username, string password, string alias);
        void OpenPool(string hostname, int port, string databaseName, Orient.Client.ODatabaseType databaseType, string username, string password, string alias);
        void ClosePool(string alias);
    }
}
