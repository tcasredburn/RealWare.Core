using System;
using System.ComponentModel.DataAnnotations;

namespace RealWare.Core.API.Models
{
    public abstract class RWFinanceService : RWPersonAddress
    {
        public long? AssociatedFinanceServiceID
        {
            get;
            set;
        }

        [StringLength(60, ErrorMessage = "Value cannot be longer than 60 characters.")]
        public string FinanceServiceBusinessName
        {
            get;
            set;
        }

        [Required]
        [StringLength(200, ErrorMessage = "Value cannot be longer than 200 characters.")]
        public string FinanceServiceCode
        {
            get;
            set;
        }

        public long? FinanceServiceGroupID
        {
            get;
            set;
        }

        [Required]
        public long FinanceServiceID
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string FinanceServiceLicenseNo
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string FinanceServiceRegNo
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public DateTime? PersonFinanceServiceOD0
        {
            get;
            set;
        }

        public DateTime? PersonFinanceServiceOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PersonFinanceServiceOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PersonFinanceServiceOM1
        {
            get;
            set;
        }

        public decimal? PersonFinanceServiceON0
        {
            get;
            set;
        }

        public decimal? PersonFinanceServiceON1
        {
            get;
            set;
        }

        public decimal? PersonFinanceServiceON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PersonFinanceServiceOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PersonFinanceServiceOT1
        {
            get;
            set;
        }

        public int? TaxYear
        {
            get;
            set;
        }

        protected RWFinanceService()
        {
        }
    }
}
