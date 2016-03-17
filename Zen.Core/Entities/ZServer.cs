using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Interfaces;

namespace Zen.Core.Entities
{
    public class ZServer : Orient.Client.OServer, IZServer
    {
        public ZServer(string hostname, int port, string userName, string userPassword) :
            base(hostname, port, userName, userPassword) { }
    }
}
