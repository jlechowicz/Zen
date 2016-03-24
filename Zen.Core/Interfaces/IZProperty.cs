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
        bool Mandatory { get; set; }
        bool ReadOnly { get; set; }
        bool NotNull { get; set; }
        object DefaultValue { get; set; }
        object Collate { get; set; }
        object Min { get; set; }
        object Max { get; set; }
        string RegExp { get; set; }
        Type LinkedType { get; set; }
        Type LinkedClass { get; set; }
        Orient.Client.OType ValueType { get; set; }
    }
}
