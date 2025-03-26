using System.Collections.Generic;

namespace RealWare.Core.ExternalApproach.Models.Result
{
    /// <summary>
    /// Result returned from the External Cost Approach service.
    /// </summary>
    public class CostExternalMarketApproachResult
    {
        public string AccountNo { get; set; }
        public double? ImpNo { get; set; }
        public double? TotalExternalCostValue { get; set; }
        public List<RWCostBuiltAsValue> BuiltAs { get; set; }
    }
}
