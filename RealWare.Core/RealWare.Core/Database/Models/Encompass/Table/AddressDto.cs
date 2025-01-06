using RealWare.Core.Database.Models.Encompass.Base;
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
        public decimal? AddressNo { get; set; }
        public decimal? AddressOn1 { get; set; }
        public decimal? AddressOn2 { get; set; }
        public decimal JurisdictionId { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public DateTime? AddressDo0 { get; set; }
        public DateTime? AddressDo1 { get; set; }
        public string AddressOm0 { get; set; }
        public string AddressOm1 { get; set; }
        public string AddressOt0 { get; set; }
        public string AddressOt1 { get; set; }
        public decimal AddressValidFlag { get; set; }
        public DateTime? WriteDate { get; set; }
        public decimal PrivateFlag { get; set; }

        /// <summary>
        /// Returns true if the PrivateFlag is not 0
        /// </summary>
        public bool IsPrivate => PrivateFlag != 0;
    }
}
