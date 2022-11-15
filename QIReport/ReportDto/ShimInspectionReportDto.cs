using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims.ReportDto
{
    public class ShimInspectionReportDto : InspectionReportDto
    {
        public decimal AverageDimension { get; set; }
        public decimal DifferenceMaxMin { get; set; }
    }
}
