using QualityShims.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims.ViewModel
{
    public class ShimInspectionReportViewModel
    {
        public int Id { get; set; }
        public string PartType { get; set; }
        public string PartNo { get; set; }
        public string OrderNo { get; set; }
        public string BatchNo { get; set; }
        public string SerialNo { get; set; }
        public DateTime Date { get; set; }
        public string Inspector { get; set; }
        public bool InspectionStatus { get; set; }
    }
}
