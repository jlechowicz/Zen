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
        public object Collate { get; set; }

        public object DefaultValue { get; set; }

        public Type LinkedClass { get; set; }

        public Type LinkedType { get; set; }

        public bool Mandatory { get; set; }

        public object Max { get; set; }

        public object Min { get; set; }

        public bool NotNull { get; set; }

        public string PropertyName { get; set; }

        public bool ReadOnly { get; set; }

        public string RegExp { get; set; }

        public OType ValueType { get; set; }
    }
}
