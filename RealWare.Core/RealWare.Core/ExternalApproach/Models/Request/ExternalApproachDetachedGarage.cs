using System;

namespace RealWare.Core.ExternalApproach.Models.Request
{
    public class ExternalApproachDetachedGarage : ExternalApproachApexImpDetailBase
    {
        public int? DetailYearBuilt { get; set; }
        public string ImpDetailType { get; set; }
        public int ImpDetailTypeID { get; set; }
        public int? PhysicalAge { get; set; }
        public decimal? PhysicalDeprPct { get; set; }
        public decimal? PhysicalDeprValue { get; set; }
    }
}
