﻿using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Lookup
{
    public class ImpsResRoofCoverTypeDto : RealWareDtoBase
    {
        public string RoofCover { get; set; }
        public string PropertyType { get; set; }
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
