using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims.Model
{
    public class ShimInspectionReport : InspectionReport
    {
        public decimal AverageDimension
        {
            get => ActualDimensions.Average(x => x.ActualValue);
            private set { }
        }
        public decimal DifferenceMaxMin
        {
            get => ActualDimensions.Max(x => x.ActualValue) - ActualDimensions.Min(x => x.ActualValue);
            private set { }
        }
    }
}
