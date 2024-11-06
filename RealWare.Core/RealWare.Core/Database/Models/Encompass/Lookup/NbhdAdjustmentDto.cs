using RealWare.Core.Database.Models.Encompass.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class NbhdAdjustmentDto : RealWareDtoBase
    {
        public string NbhdCode { get; set; }
        public string NbhdExtension { get; set; }
        public decimal NbhdAdjustmentValue { get; set; }
        public string NbhdDescription { get; set; }
        public string PropertyType { get; set; }
        public decimal TaxYear { get; set; }
        public decimal SortOrder { get; set; }
        public decimal ActiveFlag { get; set; }
        public decimal JurisdictionId { get; set; }
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Returns true if the ActiveFlag is not 0
        /// </summary>
        public bool IsActive => ActiveFlag != 0;
    }

}
