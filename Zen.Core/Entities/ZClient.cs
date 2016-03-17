using Orient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Interfaces;

namespace Zen.Core.Entities
{
    public class ZClient : IZClient
    {
        public int BufferLength
        {
            get
            {
                return OClient.BufferLenght;
            }

            set
            {
                OClient.BufferLenght = value;
            }
        }

        public string DriverName
        {
            get
            {
                return OClient.DriverName;
            }
        }

        public string DriverVersion
        {
            get
            {
                return OClient.DriverVersion;
            }
        }

        public short ProtocolVersion
        {
            get
            {
                return OClient.ProtocolVersion;
            }
        }

        public void CreateDatabasePool(string hostname, int port, string databaseName, ODatabaseType databaseType, string userName, string userPassword, int poolSize, string alias)
        {
            OClient.CreateDatabasePool(hostname, port, databaseName, databaseType, userName, userPassword, poolSize, alias);
        }

        public int DatabasePoolCurrentSize(string alias)
        {
            return OClient.DatabasePoolCurrentSize(alias);
        }

        public void DropDatabasePool(string alias)
        {
            OClient.DropDatabasePool(alias);
        }
    }
}
