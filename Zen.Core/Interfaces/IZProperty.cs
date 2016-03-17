using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IZProperty
    {
        string PropertyName { get; set; }
        Orient.Client.OType ValueType { get; set; }
        IZClass Class { get; set; }
    }
}
