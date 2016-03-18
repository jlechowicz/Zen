using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Interfaces;

namespace Zen.Core.Entities
{
    public class ZClass : IZClass
    {
        public string Name { get; set; }

        public IZProperty[] Properties { get; set; }
    }
}
