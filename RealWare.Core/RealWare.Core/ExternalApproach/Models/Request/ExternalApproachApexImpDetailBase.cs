using System;
using System.Collections.Generic;
using System.Text;

namespace RealWare.Core.ExternalApproach.Models.Request
{
    public class ExternalApproachApexImpDetailBase : ExternalApproachImpDetailBase
    {
        public long? ApexID { get; set; }
        public bool ApexLinkFlag { get; set; }
        public decimal? CostRCN { get; set; }
        public decimal? CostRCNLD { get; set; }
        public decimal? CostUnitPrice { get; set; }
    }
}
