using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims.Model
{
    public class InspectionReport
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string BatchNo { get; set; }
        public string SerialNo { get; set; }
        public DateTime Date { get; set; }
        public bool VisualInspectionStatus { get; set; }
        public bool InspectionStatus
        {
            get => !ActualDimensions.Any(x => x.IsWithinTolerance == false) && VisualInspectionStatus == true;
            private set { }
        }
        public string? Remarks { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
        public ICollection<ActualDimension> ActualDimensions { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
