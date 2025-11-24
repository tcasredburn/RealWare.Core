using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Table
{
    public class PermitDto : RealWareDtoBase
    {
        public decimal VerStart { get; set; }                    // numeric(11,0) NOT NULL
        public decimal VerEnd { get; set; }                      // numeric(11,0) NOT NULL
        public string PermitNo { get; set; }                     // varchar(50) NOT NULL

        public string AccountNo { get; set; }
        public string LocalPermitNo { get; set; }
        public string PermitSource { get; set; }
        public string PermitType { get; set; }
        public string PermitClassification { get; set; }
        public DateTime? PermitDate { get; set; }
        public decimal? PermitAmount { get; set; }
        public decimal? PermitFee { get; set; }
        public string PermitReason { get; set; }
        public string PermitReasonDetail { get; set; }
        public string IssuedBy { get; set; }
        public string PlannersApproval { get; set; }
        public decimal? ValueChangeValue { get; set; }
        public DateTime? PermitExpirationDate { get; set; }
        public string PermitUse { get; set; }
        public decimal? PermitActiveFlag { get; set; }
        public string ElectricProvider { get; set; }
        public string ElectricService { get; set; }
        public string SepticPermitNo { get; set; }
        public decimal? ValueChangeTaxYear { get; set; }
        public string PermitBatchNumber { get; set; }
        public decimal? ContractorCode { get; set; }
        public decimal? LenderCode { get; set; }
        public string ValueChangeAppliedTo { get; set; }
        public string PermitOTO { get; set; }
        public string PermitOT1 { get; set; }
        public string PermitOT0 { get; set; }
        public string PermitOM1 { get; set; }
        public decimal? PermitON0 { get; set; }
        public decimal? PermitON1 { get; set; }
        public decimal? PermitON2 { get; set; }
        public decimal? PrimaryImpNo { get; set; }
        public DateTime? PermitOD0 { get; set; }
        public DateTime? PermitOD1 { get; set; }
        public decimal JurisdictionId { get; set; }
        public string AssignedTo { get; set; }
        public string PermitStatus { get; set; }
        public string PermitPriority { get; set; }
        public string PermitWorkedBy { get; set; }
        public DateTime? PermitWorkDate { get; set; }
        public DateTime? VisitDate { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public DateTime? CertificateOfOccupancyDate { get; set; }
        public string FemaType { get; set; }
        public decimal SeqId { get; set; }

        /// <summary>
        /// Returns true if PermitActiveFlag is not 0.
        /// </summary>
        public bool IsPermitActive => (PermitActiveFlag ?? 0) != 0;
    }
}
