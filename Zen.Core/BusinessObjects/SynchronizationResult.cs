using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.BusinessObjects
{
    public class SynchronizationResult
    {
        public bool IsSuccessful { get; set; }
        public SynchronizationDirection Direction { get; set; }
        public string Message { get; set; }
    }
}
