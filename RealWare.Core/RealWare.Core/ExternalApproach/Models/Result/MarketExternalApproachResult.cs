using System.Collections.Generic;

namespace RealWare.Core.ExternalApproach.Models.Result
{
    /// <summary>
    /// Result returned from the External Market Approach service.
    /// </summary>
    public class MarketExternalApproachResult
    {
        public List<RWImprovementOccupancyValue> ImprovementOccupancyValues { get; set; }
    }
}
