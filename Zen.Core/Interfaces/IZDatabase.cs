using Orient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IZDatabase : IDisposable
    {
        string Name { get; set; }
        IZClass[] Classes { get; }
        IZUser[] Users { get; }
        IZRole[] Roles { get; }
        OCommandResult Command(string sql);
    }
}
