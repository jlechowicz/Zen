using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    interface IPropertyService
    {
        IZProperty[] GetPropertiesFromClass(IZDatabase database, string className);
    }
}
