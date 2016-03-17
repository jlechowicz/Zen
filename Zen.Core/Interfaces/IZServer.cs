using Orient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IZServer : IDisposable
    {
        void Close();
        bool CreateDatabase(string databaseName, ODatabaseType databaseType, OStorageType storageType);
        bool DatabaseExist(string databaseName);
        void DropDatabase(string databaseName);
    }
}
