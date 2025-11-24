using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Table
{
    public class SaleDto : RealWareDtoBase
    {
        public decimal VerStart { get; set; }
        public decimal VerEnd { get; set; }
        public string ReceptionNo { get; set; }     // NOT NULL

        public string Book { get; set; }
        public string Page { get; set; }
        public string Grantor { get; set; }
        public string Grantee { get; set; }
        public DateTime? DocumentDate { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? DocumentFee { get; set; }
        public string DeedCode { get; set; }
        public decimal? PenaltyFlag { get; set; }
        public DateTime? PenaltyDate { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? PPadjAmount { get; set; }
        public decimal? GoodwillAdjAmount { get; set; }
        public decimal? OtherAdjAmount { get; set; }
        public decimal? TimeAdj { get; set; }
        public decimal? DownPaymentAmount { get; set; }
        public decimal? DownPaymentPct { get; set; }
        public decimal? NoteAmount { get; set; }
        public decimal? InterestRatePct { get; set; }
        public decimal? LoanTerm { get; set; }
        public decimal? PointsPaid { get; set; }
        public string PointsPaidBy { get; set; }
        public string LoanInstitution { get; set; }
        public decimal? MktRatePct { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? RecourseFlag { get; set; }
        public string Tenant { get; set; }
        public decimal? Valid1Flag { get; set; }
        public decimal? Valid2Flag { get; set; }
        public decimal? ConfirmedFlag { get; set; }
        public string ExcludeCode1 { get; set; }
        public string ExcludeCode2 { get; set; }
        public decimal? ImprovedFlag { get; set; }
        public string ConfirmBy { get; set; }
        public string ConfirmMethod { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string Comments { get; set; }
        public decimal? NonSaleFlag { get; set; }

        public decimal? SaleON0 { get; set; }
        public decimal? SaleON1 { get; set; }
        public decimal? SaleON2 { get; set; }
        public DateTime? SaleOD0 { get; set; }
        public DateTime? SaleOD1 { get; set; }
        public string SaleOM0 { get; set; }
        public string SaleOM1 { get; set; }
        public string SaleOT0 { get; set; }
        public string SaleOT1 { get; set; }

        public decimal JurisdictionId { get; set; }
        public DateTime? WriteDate { get; set; }
        public decimal? BalloonPaymentYear { get; set; }
        public decimal? TransferDeclarationFlag { get; set; }
        public DateTime? TransferDeclarationDate { get; set; }
        public DateTime? QuestionnaireMailDate { get; set; }
        public DateTime? QuestionnaireReturnDate { get; set; }
        public decimal SeqId { get; set; }
        public string DocumentStatus { get; set; }

        /// <summary> Sale is valid if Valid1Flag != 0 or Valid2Flag != 0. </summary>
        public bool IsValid => (Valid1Flag ?? 0) != 0 || (Valid2Flag ?? 0) != 0;

        /// <summary> Returns true if NonSaleFlag != 0. </summary>
        public bool IsNonSale => (NonSaleFlag ?? 0) != 0;

        /// <summary> Returns true if ConfirmedFlag != 0. </summary>
        public bool IsConfirmed => (ConfirmedFlag ?? 0) != 0;
    }
}
