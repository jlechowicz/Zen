using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Interfaces;

namespace Zen.Core.Entities
{
    public class ZDatabase : IZDatabase
    {
        public IZClass[] Classes { get; set; }

        public string Name { get; set; }

        public IZRole[] Roles { get; set; }

        public IZUser[] Users { get; set; }
    }
}
