using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class PropertyClassDto : RealWareDtoBase
    {
        public decimal PropertyClassId { get; set; }
        public string PropertyClassCode { get; set; }
        public string PropertyClassDescription { get; set; }
        public string PropertyClassStateCode { get; set; }
        public string CPRPropertyClassCode { get; set; }
        public decimal JurisdictionId { get; set; }
        public decimal ActiveFlag { get; set; }
        public decimal SortOrder { get; set; }
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Returns true if the ActiveFlag is not 0
        /// </summary>
        public bool IsActive => ActiveFlag != 0;
    }
}
