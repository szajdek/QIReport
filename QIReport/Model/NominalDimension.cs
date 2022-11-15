using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityShims.Model
{
    public class NominalDimension
    {
        public int Id { get; set; }
        public int BalloonNo { get; set; }
        public decimal NominalValue { get; set; }
        public decimal UpperDeviation { get; set; }
        public decimal LowerDeviation { get; set; }
        [NotMapped]
        public decimal UpperLimit
        {
            get => NominalValue + UpperDeviation;
            private set { }
        }
        [NotMapped]
        public decimal LowerLimit
        {
            get => NominalValue + LowerDeviation;
            private set { }
        }
        public int PartId { get; set; }
        public Part Part { get; set; }
    }
}
