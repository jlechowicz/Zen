using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IZDatabase
    {
        string Name { get; set; }
        IZClass[] Classes { get; set; }
        IZUser[] Users { get; set; }
        IZRole[] Roles { get; set; }
    }
}
