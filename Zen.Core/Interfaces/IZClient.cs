using Orient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IZClient
    {
        int BufferLength { get; set; }
        string DriverName { get; }
        string DriverVersion { get; }
        short ProtocolVersion { get; }

        void CreateDatabasePool(string hostname, int port, string databaseName, ODatabaseType databaseType, string userName, string userPassword, int poolSize, string alias);
        int DatabasePoolCurrentSize(string alias);
        void DropDatabasePool(string alias);
    }
}
