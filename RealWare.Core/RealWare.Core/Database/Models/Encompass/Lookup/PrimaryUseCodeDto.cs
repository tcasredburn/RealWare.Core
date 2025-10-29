using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class PrimaryUseCodeDto : RealWareDtoBase
    {
        public string PrimaryUseCode { get; set; }
        public string AppraisalType { get; set; }
        public string PrimaryUseDescription { get; set; }
        public decimal JurisdictionId { get; set; }
        public decimal? SortOrder { get; set; }
        public decimal ActiveFlag { get; set; }
        public DateTime? LastUpdated { get; set; }
        public decimal PrimaryUseCodeDeprFlag { get; set; }

        /// <summary>
        /// Returns true if the ActiveFlag is not 0
        /// </summary>
        public bool IsActive => ActiveFlag != 0;

        /// <summary>
        /// Returns true if the PrimaryUseCodeDeprFlag is not 0
        /// </summary>
        public bool IsPrimaryUseCodeDepreciated => PrimaryUseCodeDeprFlag != 0;
    }
}
