using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class ImpsConditionTypeDto : RealWareDtoBase
    {
        public string ImpConditionType { get; set; }
        public decimal CostConditionMultiplier { get; set; }
        public decimal TaxYear { get; set; }
        public decimal SortOrder { get; set; }
        public decimal ActiveFlag { get; set; }
        public decimal JurisdictionId { get; set; }
        public DateTime LastUpdated { get; set; }
        public decimal ImpsConditionRank { get; set; }

        /// <summary>
        /// Returns true if the ActiveFlag is not 0
        /// </summary>
        public bool IsActive => ActiveFlag != 0;
    }

}
