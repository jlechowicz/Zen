using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IZClass
    {
        string Name { get; set; }
        IZProperty[] Properties { get; set; }
    }
}
