using System;
using System.ComponentModel.DataAnnotations;

namespace RealWare.Core.API.Models
{
    public class RWPermitApplicant : RWPersonAddress
    {
        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [Required]
        public bool OwnerFlag
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitApplicantBusinessName
        {
            get;
            set;
        }

        public DateTime? PermitApplicantOD0
        {
            get;
            set;
        }

        public DateTime? PermitApplicantOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitApplicantOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitApplicantOM1
        {
            get;
            set;
        }

        public decimal? PermitApplicantON0
        {
            get;
            set;
        }

        public decimal? PermitApplicantON1
        {
            get;
            set;
        }

        public decimal? PermitApplicantON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitApplicantOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitApplicantOT1
        {
            get;
            set;
        }

        [Required]
        public bool PrimaryApplicantFlag
        {
            get;
            set;
        }

        public RWPermitApplicant()
        {
        }
    }
}
