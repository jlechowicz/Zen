using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Interfaces;

namespace Zen.Core.Comparers
{
    public class PropertyComparer : IEqualityComparer<IZProperty>
    {
        public bool Equals(IZProperty prop1, IZProperty prop2)
        {
            return prop1.GetHashCode() == prop2.GetHashCode();
        }

        public int GetHashCode(IZProperty prop)
        {
            return string.Format("{0}{1}", prop.PropertyName, prop.ValueType).GetHashCode();
        }
    }
}
