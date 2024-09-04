using System.Collections.Generic;

namespace RealWare.Core.ExternalApproach.Models.Result
{
    /// <summary>
    /// Result returned from the External Income Approach service.
    /// </summary>
    public class IncomeExternalApproachResult
    {
        public List<RWImprovementOccupancyValue> ImprovementOccupancyValues { get; set; }
    }
}
