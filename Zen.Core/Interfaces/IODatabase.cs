using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IODatabase
    {
        string ServerAddress { get; set; }
        string Name { get; set; }
        int Port { get; set; }
        int Connect(string username, string password);
        IOClass[] GetClasses();
        object[] GetUsers();
        object[] GetRoles();
    }
}
