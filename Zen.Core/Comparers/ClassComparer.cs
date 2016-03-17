using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Interfaces;

namespace Zen.Core.Comparers
{
    public class ClassComparer : IEqualityComparer<IZClass>
    {
        public bool Equals(IZClass zclass1, IZClass zclass2)
        {
            return zclass1.GetHashCode() == zclass2.GetHashCode();
        }

        public int GetHashCode(IZClass zclass)
        {
            return string.Format("{0}{1}", zclass.Name,string.Join("",zclass.Properties.Select(prop => string.Format("{0}{1}",prop.PropertyName, prop.ValueType)))).GetHashCode();
        }
    }
}
