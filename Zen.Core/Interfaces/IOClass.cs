﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.Interfaces
{
    public interface IOClass
    {
        string Name { get; set; }
        IOProperty[] Properties { get; set; }
    }
}
