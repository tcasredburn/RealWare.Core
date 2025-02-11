using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Table
{
    public class AcctDto : RealWareDtoBase
    {
        public decimal VerStart { get; set; }
        public decimal VerEnd { get; set; }
        public string AccountNo { get; set; }
        public string ParcelNo { get; set; }
        public string LocalNo { get; set; }
        public string MapNo { get; set; }
        public string AcctStatusCode { get; set; }
        public string AcctType { get; set; }
        public string AssignedTo { get; set; }
        public string ValueAreaCode { get; set; }
        public string AssociatedAcct { get; set; }
        public string AppraisalType { get; set; }
        public string EconomicAreaCode { get; set; }
        public DateTime? AcctDateCreated { get; set; }
        public string DefaultApproachType { get; set; }
        public string DefaultTaxDistrict { get; set; }
        public string BusinessLicense { get; set; }
        public string MapGroup { get; set; }
        public string ControlMap { get; set; }
        public string PropertyIdentifier { get; set; }
        public string SpecialInterestNumber { get; set; }
        public decimal? AcctON0 { get; set; }
        public decimal? AcctON1 { get; set; }
        public decimal? AcctON2 { get; set; }
        public string PrimaryUseCode { get; set; }
        public string Ward { get; set; }
        public DateTime? AcctOD0 { get; set; }
        public DateTime? AcctOD1 { get; set; }
        public string AcctOM0 { get; set; }
        public string AcctOM1 { get; set; }
        public string StrippedAccountNo { get; set; }
        public decimal JurisdictionId { get; set; }
        public string AcctOT0 { get; set; }
        public string AcctOT1 { get; set; }
        public DateTime? WriteDate { get; set; }
        public string CensusTract { get; set; }
        public string CensusBlock { get; set; }
        public string MobileHomeSpace { get; set; }
        public decimal EFileFlag { get; set; }
        public string BusinessName { get; set; }
        public decimal? CostHybridPercent { get; set; }
        public decimal? MarketHybridPercent { get; set; }
        public decimal? IncomeHybridPercent { get; set; }
        public decimal? ReconciledHybridPercent { get; set; }
        public decimal? ParcelSequence { get; set; }
        public decimal PropertyClassId { get; set; }
        public decimal SeqId { get; set; }
        public DateTime? DetailedReviewDate { get; set; }

        /// <summary>
        /// Returns true if the EFileFlag is not 0
        /// </summary>
        public bool IsEFile => EFileFlag != 0;
    }
}
