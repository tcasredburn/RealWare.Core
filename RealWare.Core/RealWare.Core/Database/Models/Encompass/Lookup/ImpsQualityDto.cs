using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class ImpsQualityDto : RealWareDtoBase
    {
        public string ImpQuality { get; set; }
        public decimal CostMHTAGMultiplier { get; set; }
        public decimal ImpQualityRank { get; set; }
        public decimal SortOrder { get; set; }
        public decimal ActiveFlag { get; set; }
        public decimal JurisdictionId { get; set; }
        public DateTime LastUpdated { get; set; }
        public decimal QualityValue { get; set; }

        /// <summary>
        /// Returns true if the ActiveFlag is not 0
        /// </summary>
        public bool IsActive => ActiveFlag != 0;
    }
}
