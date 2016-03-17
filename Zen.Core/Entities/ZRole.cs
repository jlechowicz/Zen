using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Interfaces;

namespace Zen.Core.Entities
{
    public class ZRole : IZRole
    {
        public string Name { get; set; }

        public IZUser[] UsersInRole { get; set; }
    }
}
