using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWPermitUtilityProvider : RWBase
    {
        public long? DetailID
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public DateTime? PermitUtilityProviderOD0
        {
            get;
            set;
        }

        public DateTime? PermitUtilityProviderOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitUtilityProviderOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitUtilityProviderOM1
        {
            get;
            set;
        }

        public decimal? PermitUtilityProviderON0
        {
            get;
            set;
        }

        public decimal? PermitUtilityProviderON1
        {
            get;
            set;
        }

        public decimal? PermitUtilityProviderON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitUtilityProviderOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitUtilityProviderOT1
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string UtilityAccessible
        {
            get;
            set;
        }

        [Required]
        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string UtilityProviderName
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string UtilityServiceType
        {
            get;
            set;
        }

        public RWPermitUtilityProvider()
        {
        }
    }
}
