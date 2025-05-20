using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class DeedTypeDto : RealWareDtoBase
    {
        public string DeedCode { get; set; }
        public string DeedDescription { get; set; }
        public decimal SortOrder { get; set; }
        public decimal ActiveFlag { get; set; }
        public decimal EffectExemptionsFlag { get; set; }
        public decimal EffectCapFlag { get; set; }
        public decimal IncludeInSalesRatiosFlag { get; set; }
        public decimal JurisdictionId { get; set; }
        public decimal NonSaleFlag { get; set; }
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Returns true if the ActiveFlag is not 0
        /// </summary>
        public bool IsActive => ActiveFlag != 0;

        /// <summary>
        /// Returns true if the EffectExemptionsFlag is not 0
        /// </summary>
        public bool IsEffectExemptionsFlag => EffectExemptionsFlag != 0;

        /// <summary>
        /// Returns true if the EffectCapFlag is not 0
        /// </summary>
        public bool IsEffectCapFlag => EffectCapFlag != 0;

        /// <summary>
        /// Returns true if the IncludeInSalesRatiosFlag is not 0
        /// </summary>
        public bool IsIncludeInSalesRatiosFlag => IncludeInSalesRatiosFlag != 0;

        /// <summary>
        /// Returns true if the NonSaleFlag is not 0
        /// </summary>
        public bool IsNonSaleFlag => NonSaleFlag != 0;
    }
}
