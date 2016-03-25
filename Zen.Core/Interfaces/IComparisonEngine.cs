using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Core.BusinessObjects;

namespace Zen.Core.Interfaces
{
    public interface IComparisonEngine
    {
        SynchronizationDirection SyncDirection { get; set; }
        IConnection SourceConnection { get; set; }
        IConnection DestinationConnection { get; set; }
        IEqualityComparer<IZClass> ClassComparer { get; set; }
        IEqualityComparer<IZProperty> PropertyComparer { get; set; }
        ComparisonResult[] CompareObjects();
    }
}
