using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims.ReportDto
{
    public class InspectionReportDto
    {
        public string Id { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public string OrderNo { get; set; }
        public string BatchNo { get; set; }
        public string SerialNo { get; set; }
        public DateTime Date { get; set; }
        public string Inspector { get; set; }
        public bool VisualInspectionStatus { get; set; }
        public string? Remarks { get; set; }
        public ICollection<DimensionDto> Dimensions { get; set; }
    }
}
