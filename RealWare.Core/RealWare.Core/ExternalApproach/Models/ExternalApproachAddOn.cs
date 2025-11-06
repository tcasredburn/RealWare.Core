using RealWare.Core.ExternalApproach.Models.Request;
using System;

namespace RealWare.Core.ExternalApproach.Models
{
    public class ExternalApproachAddOn : ExternalApproachApexImpDetailBase
    {
        public long AddonCode { get; set; }
        public bool CostImpDetailOverrideFlag { get; set; }
        public decimal? CostOverrideValue { get; set; }
        public decimal? DetailUnitCount { get; set; }
        public int? DetailYearBuild { get; set; }
        public int? OverrideLifeExpectancy { get; set; }
        public int? PhysicalAge { get; set; }
        public decimal? PhysicalDeprPct { get; set; }
        public decimal? PhysicalDeprValue { get; set; }
    }
}
