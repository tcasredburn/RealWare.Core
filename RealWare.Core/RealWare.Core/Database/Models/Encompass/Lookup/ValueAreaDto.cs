using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class ValueAreaDto : RealWareDtoBase
    {
        public string ValueAreaCode { get; set; }
        public decimal ActiveFlag { get; set; }
        public decimal SortOrder { get; set; }
        public string ValueAreaDescription { get; set; }
        public decimal JurisdictionId { get; set; }
        public decimal MassIncludeFlag { get; set; }
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Returns true if the ActiveFlag is not 0
        /// </summary>
        public bool IsActive => ActiveFlag != 0;
    }

}
