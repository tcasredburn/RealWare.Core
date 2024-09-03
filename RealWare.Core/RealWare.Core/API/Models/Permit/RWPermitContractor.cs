using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RealWare.Core.API.Models.Permit
{
    public class RWPermitContractor : RWPersonAddress
    {
        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ContractorBusinessName
        {
            get;
            set;
        }

        [Required]
        public long ContractorCode
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string ContractorLicenseNo
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string ContractorRegistrationNo
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public DateTime? PermitContractorOD0
        {
            get;
            set;
        }

        public DateTime? PermitContractorOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitContractorOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitContractorOM1
        {
            get;
            set;
        }

        public decimal? PermitContractorON0
        {
            get;
            set;
        }

        public decimal? PermitContractorON1
        {
            get;
            set;
        }

        public decimal? PermitContractorON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitContractorOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitContractorOT1
        {
            get;
            set;
        }

        public RWPermitContractor()
        {
        }
    }
}
