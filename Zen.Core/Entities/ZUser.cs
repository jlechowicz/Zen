using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.Interfaces;

namespace Zen.Core.Entities
{
    public class ZUser : IZUser
    {
        public IZRole[] Roles { get; set; }

        public string Username { get; set; }
    }
}
