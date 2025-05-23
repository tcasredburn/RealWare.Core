﻿using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Table
{
    public class AddressDto : RealWareDtoBase
    {
        public decimal SeqId { get; set; }
        public decimal VerStart { get; set; }
        public decimal VerEnd { get; set; }
        public decimal AddressCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public decimal? PersonCode { get; set; }
        public string Province { get; set; }
        public decimal? AddressON0 { get; set; }
        public decimal? AddressON1 { get; set; }
        public decimal? AddressON2 { get; set; }
        public decimal JurisdictionId { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public DateTime? AddressOD0 { get; set; }
        public DateTime? AddressOD1 { get; set; }
        public string AddressOM0 { get; set; }
        public string AddressOM1 { get; set; }
        public string AddressOT0 { get; set; }
        public string AddressOT1 { get; set; }
        public decimal AddressValidFlag { get; set; }
        public DateTime? WriteDate { get; set; }
        public decimal PrivateFlag { get; set; }

        /// <summary>
        /// Returns true if the PrivateFlag is not 0
        /// </summary>
        public bool IsPrivate => PrivateFlag != 0;
    }
}
