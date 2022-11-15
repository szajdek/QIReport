using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims.Model
{
    public class ActualDimension
    {
        public int Id { get; set; }
        public decimal ActualValue { get; set; }
        public decimal Deviation
        {
            get => ActualValue - NominalDimension.NominalValue;
            private set { }
        }
        public bool IsWithinTolerance
        {
            get => ActualValue >= NominalDimension.LowerLimit && ActualValue <= NominalDimension.UpperLimit;
            private set { }
        }
        public int NominalDimensionId { get; set; }
        public NominalDimension NominalDimension { get; set; }
        public int InspectionReportId { get; set; }
        public InspectionReport InspectionReport { get; set; }
    }
}
