using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Table
{
    public class PersonDto : RealWareDtoBase
    {
        public decimal SeqId { get; set; }
        public decimal VerStart { get; set; }
        public decimal VerEnd { get; set; }
        public decimal PersonCode { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Pager { get; set; }
        public string EmailAddress { get; set; }
        public string FederalIdNo { get; set; }
        public decimal PrivateFlag { get; set; }
        public decimal? PersonON0 { get; set; }
        public decimal? PersonON1 { get; set; }
        public decimal? PersonON2 { get; set; }
        public string AltName1 { get; set; }
        public DateTime? PersonOD0 { get; set; }
        public DateTime? PersonOD1 { get; set; }
        public string PersonOM0 { get; set; }
        public string PersonOM1 { get; set; }
        public string PersonOT0 { get; set; }
        public string PersonOT1 { get; set; }
        public DateTime? WriteDate { get; set; }
        public decimal PersonTypeId { get; set; }
        public decimal JurisdictionId { get; set; }
        public string MetaphoneName1 { get; set; }
        public string MetaphoneName2 { get; set; }

        /// <summary>
        /// Returns true if the PrivateFlag is not 0
        /// </summary>
        public bool IsPrivate => PrivateFlag != 0;
    }
}
