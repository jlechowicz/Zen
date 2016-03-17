using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orient.Client;
using Zen.Core.Interfaces;

namespace Zen.Core.Entities
{
    public class ZProperty : IZProperty
    {
        public IZClass Class { get; set; }

        public string PropertyName { get; set; }

        public OType ValueType { get; set; }
    }
}
