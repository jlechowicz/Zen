using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IODatabase
    {
        string Name { get; set; }
        IOClass[] Classes { get; set; }
        IOUser[] Users { get; set; }
        IORole[] Roles { get; set; }
    }
}
