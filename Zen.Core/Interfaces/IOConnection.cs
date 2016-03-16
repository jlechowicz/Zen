using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IOConnection : IDisposable
    {
        string Username { get; set; }
        string Password { get; set; }
        string ServerAddress { get; set; }
        int Port { get; set; }
        int Open();
        int Close();
    }
}
