using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Core.BusinessObjects
{
    public class ComparisonResult
    {
        public ComparisonResultType Type { get; set; }
        public string Message { get; set; }
        public object SourceInput { get; set; }
        public object DestinationInput { get; set; }
    }
}
