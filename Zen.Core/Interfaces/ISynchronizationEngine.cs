using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.BusinessObjects;

namespace Zen.Core.Interfaces
{
    public interface ISynchronizationEngine
    {
        IComparisonEngine ComparisonEngine { get; set; }
        SynchronizationResult[] SyncObjects();
    }
}
