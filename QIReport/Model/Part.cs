using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims.Model
{
    public class Part
    {
        public int Id { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public int PartTypeId { get; set; }
        public PartType PartType { get; set; }
        public ICollection<NominalDimension> NominalDimensions { get; set; }
        public ICollection<InspectionReport> InspectionReports { get; set; }
    }
}
