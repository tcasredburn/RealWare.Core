using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWSale : RWBase
    {
        public List<RWSaleAccount> Accounts
        {
            get;
            set;
        }

        public int? BalloonPaymentYear
        {
            get;
            set;
        }

        [StringLength(6, ErrorMessage = "Value cannot be longer than 6 characters.")]
        public string Book
        {
            get;
            set;
        }

        [StringLength(500, ErrorMessage = "Value cannot be longer than 500 characters.")]
        public string Comments
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ConfirmBy
        {
            get;
            set;
        }

        public DateTime? ConfirmDate
        {
            get;
            set;
        }

        public bool ConfirmedFlag
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ConfirmMethod
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string DeedCode
        {
            get;
            set;
        }

        public DateTime? DocumentDate
        {
            get;
            set;
        }

        public decimal DocumentFee
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string DocumentStatus
        {
            get;
            set;
        }

        public decimal DownPaymentAmount
        {
            get;
            set;
        }

        public decimal DownPaymentPct
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ExcludeCode1
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ExcludeCode2
        {
            get;
            set;
        }

        public decimal GoodwillAdjAmount
        {
            get;
            set;
        }

        [StringLength(80, ErrorMessage = "Value cannot be longer than 80 characters.")]
        public string Grantee
        {
            get;
            set;
        }

        [StringLength(80, ErrorMessage = "Value cannot be longer than 80 characters.")]
        public string Grantor
        {
            get;
            set;
        }

        public bool ImprovedFlag
        {
            get;
            set;
        }

        public decimal InterestRatePct
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LoanInstitution
        {
            get;
            set;
        }

        public decimal LoanTerm
        {
            get;
            set;
        }

        public decimal MktRatePct
        {
            get;
            set;
        }

        public bool NonSaleFlag
        {
            get;
            set;
        }

        public decimal NoteAmount
        {
            get;
            set;
        }

        public List<RWNote> Notes
        {
            get;
            private set;
        }

        public decimal OtherAdjAmount
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string Page
        {
            get;
            set;
        }

        public decimal PaymentAmount
        {
            get;
            set;
        }

        public DateTime? PenaltyDate
        {
            get;
            set;
        }

        public bool PenaltyFlag
        {
            get;
            set;
        }

        public decimal? PointsPaid
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string PointsPaidBy
        {
            get;
            set;
        }

        public decimal PPAdjAmount
        {
            get;
            set;
        }

        public DateTime? QuestionnaireMailDate
        {
            get;
            set;
        }

        public DateTime? QuestionnaireReturnDate
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ReceptionNo
        {
            get;
            set;
        }

        public bool RecourseFlag
        {
            get;
            set;
        }

        [Required]
        public DateTime SaleDate
        {
            get;
            set;
        }

        public DateTime? SaleOD0
        {
            get;
            set;
        }

        public DateTime? SaleOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleOM1
        {
            get;
            set;
        }

        public decimal? SaleON0
        {
            get;
            set;
        }

        public decimal? SaleON1
        {
            get;
            set;
        }

        public decimal? SaleON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleOT1
        {
            get;
            set;
        }

        public decimal SalePrice
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string Tenant
        {
            get;
            set;
        }

        public decimal TimeAdj
        {
            get;
            set;
        }

        public DateTime? TransferDeclarationDate
        {
            get;
            set;
        }

        public bool TransferDeclarationFlag
        {
            get;
            set;
        }

        public bool Valid1Flag
        {
            get;
            set;
        }

        public bool Valid2Flag
        {
            get;
            set;
        }

        public string[] FieldPriority
        {
            get;
            set;
        }

        public RWSale()
        {
            Accounts = new List<RWSaleAccount>();
            Notes = new List<RWNote>();

            FieldPriority = GetDefaultFieldPriority();
        }

        public static string[] GetDefaultFieldPriority()
        {
            return new[] { "NoteAmount", "SalePrice", "DownPaymentAmount", "DownPaymentPct", "DocumentFee" };
        }
    }
}
