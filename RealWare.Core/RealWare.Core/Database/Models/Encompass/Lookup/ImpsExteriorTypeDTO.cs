using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class ImpsExteriorTypeDto : RealWareDtoBase
    {
        public string PropertyType { get; set; }
        public string ImpQuality { get; set; }
        public string ImpExterior { get; set; }
        public decimal SortOrder { get; set; }
        public decimal ActiveFlag { get; set; }
        public decimal CostMultiplier { get; set; }
        public decimal TaxYear { get; set; }
        public decimal JurisdictionId { get; set; }
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Returns true if the ActiveFlag is not 0
        /// </summary>
        public bool IsActive => ActiveFlag != 0;
    }
}
