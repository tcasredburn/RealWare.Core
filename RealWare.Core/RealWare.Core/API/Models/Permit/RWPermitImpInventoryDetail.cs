using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Permit
{
    public class RWPermitImpInventoryDetail : RWBase
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

        public decimal? PermitDetailON0
        {
            get;
            set;
        }

        public decimal? PermitDetailON1
        {
            get;
            set;
        }

        public decimal? PermitDetailON2
        {
            get;
            set;
        }

        [Required]
        [StringLength(35, ErrorMessage = "Value cannot be longer than 35 characters.")]
        public string PermitDetailType
        {
            get;
            set;
        }

        public decimal? PermitDetailValue
        {
            get;
            set;
        }

        public DateTime? PermitImpInventoryDetailOD0
        {
            get;
            set;
        }

        public DateTime? PermitImpInventoryDetailOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInventoryDetailOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInventoryDetailOM1
        {
            get;
            set;
        }

        public decimal? PermitImpInventoryDetailON0
        {
            get;
            set;
        }

        public decimal? PermitImpInventoryDetailON1
        {
            get;
            set;
        }

        public decimal? PermitImpInventoryDetailON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInventoryDetailOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInventoryDetailOT1
        {
            get;
            set;
        }

        public RWPermitImpInventoryDetail()
        {
        }
    }
}
