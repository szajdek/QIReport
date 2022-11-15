using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims.ReportDto
{
    public class DimensionDto
    {
        public int BalloonNo { get; set; }
        public decimal NominalValue { get; set; }
        public decimal UpperDeviation { get; set; }
        public decimal LowerDeviation { get; set; }
        public decimal ActualValue { get; set; }
        public decimal Deviation { get; set; }
        public bool IsWithinTolerance { get; set; }
    }
}
