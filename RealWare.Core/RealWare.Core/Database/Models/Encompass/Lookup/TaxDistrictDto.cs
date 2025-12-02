using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class TaxDistrictDto : RealWareDtoBase
    {
        public string TaxDistrict { get; set; }
        public string TaxDistrictName { get; set; }
        public string TaxArea { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal SortOrder { get; set; }
        public decimal ActiveFlag { get; set; }
        public decimal JurisdictionId { get; set; }
        public string TaxDistrictCategory { get; set; }
        public DateTime LastUpdated { get; set; }
        public decimal? TaxDistrictType { get; set; }
        public string AssociatedUrbanRenewalPlan { get; set; }
        public string ReportingTaxDistrict { get; set; }
        public decimal TaxDistrictId { get; set; }

        /// <summary>
        /// Returns true if the ActiveFlag is not 0
        /// </summary>
        public bool IsActive => ActiveFlag != 0;
    }
}
