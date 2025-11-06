using System;

namespace RealWare.Core.ExternalApproach.Models.Request
{
    public class ExternalApproachImpDetailBase
    {
        public long? DetailID { get; set; }
        public string ImpDetailDescription { get; set; }
        public DateTime? ImpsDetailOD0 { get; set; }
        public DateTime? ImpsDetailOD1 { get; set; }
        public string ImpsDetailOM0 { get; set; }
        public string ImpsDetailOM1 { get; set; }
        public decimal? ImpsDetailON0 { get; set; }
        public decimal? ImpsDetailON1 { get; set; }
        public decimal? ImpsDetailON2 { get; set; }
        public string ImpsDetailOT0 { get; set; }
        public string ImpsDetailOT1 { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
