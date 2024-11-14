using RealWare.Core.Database.Models.Encompass.Base;
using System;
using System.Linq;

namespace RealWare.Core.Database.Models.Encompass.Table
{
    public class AcctPropertyAddressDto : RealWareDtoBase
    {
        public decimal VerStart { get; set; }
        public decimal VerEnd { get; set; }
        public string AccountNo { get; set; }
        public string BuildingId { get; set; }
        public string PreDirection { get; set; }
        public string StreetNo { get; set; }
        public string UnitName { get; set; }
        public string PostDirection { get; set; }
        public string StreetType { get; set; }
        public string StreetName { get; set; }
        public string PropertyZipCode { get; set; }
        public string PropertyCity { get; set; }
        public decimal OrderNo { get; set; }
        public decimal AcctPropertyAddressNo { get; set; }
        public decimal AcctPropertyAddressNo1 { get; set; }
        public decimal AcctPropertyAddressNo2 { get; set; }
        public string BusinessName { get; set; }
        public string AcctPropertyAddress0 { get; set; }
        public DateTime? AcctPropertyAddressD0 { get; set; }
        public DateTime? AcctPropertyAddressD1 { get; set; }
        public decimal? AcctPropertyAddressO0 { get; set; }
        public string AcctPropertyAddressOM1 { get; set; }
        public string AcctPropertyAddressOT0 { get; set; }
        public string AcctPropertyAddressOT1 { get; set; }
        public decimal JurisdictionId { get; set; }
        public decimal PropertyAddressCode { get; set; }
        public DateTime WriteDate { get; set; }
        public decimal LocationId { get; set; }
        public decimal SeqId { get; set; }


        public string GetFormattedAddress(bool useNewline = false, bool includeBusinessName = false)
        {
            var separator = useNewline ? Environment.NewLine : ", ";

            // Include BusinessName at the top if it exists
            var businessLine = string.Empty;
            if(includeBusinessName)
                businessLine = !string.IsNullOrWhiteSpace(BusinessName) ? $"{BusinessName}{separator}" : string.Empty;

            var streetAddress = GetFormattedStreetAddress();
            var cityZip = GetFormattedCityZip();

            return $"{businessLine}{streetAddress}{separator}{cityZip}".Trim();
        }

        public string GetFormattedStreetAddress()
        {
            // Join only non-null, non-empty components, and remove extra spaces
            return string.Join(" ", new[]
            {
                StreetNo,
                PreDirection,
                StreetName,
                StreetType,
                PostDirection,
                UnitName
            }.Where(part => !string.IsNullOrWhiteSpace(part)));
        }

        public string GetFormattedCityZip()
        {
            // Join city and zip if they exist
            return string.Join(", ", new[]
            {
                PropertyCity,
                PropertyZipCode
            }.Where(part => !string.IsNullOrWhiteSpace(part)));
        }
    }
}
