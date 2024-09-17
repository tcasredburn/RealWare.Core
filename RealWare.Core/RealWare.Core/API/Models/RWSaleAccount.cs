using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWSaleAccount : RWBase
    {
        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AccountNo
        {
            get;
            set;
        }

        public decimal AcctAdjSaleprice
        {
            get;
            set;
        }

        public bool GroupPrimaryAcctFlag
        {
            get;
            set;
        }

        public RWSaleInventory Inventory
        {
            get;
            set;
        }

        [Required]
        public DateTime InventoryEffectiveDate
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public DateTime? SaleAcctOD0
        {
            get;
            set;
        }

        public DateTime? SaleAcctOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAcctOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAcctOM1
        {
            get;
            set;
        }

        public decimal? SaleAcctON0
        {
            get;
            set;
        }

        public decimal? SaleAcctON1
        {
            get;
            set;
        }

        public decimal? SaleAcctON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAcctOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAcctOT1
        {
            get;
            set;
        }

        public DateTime? SaleAcctPenaltyDate
        {
            get;
            set;
        }

        public bool SaleAcctPenaltyFlag
        {
            get;
            set;
        }

        public RWSaleAccount()
        {
        }
    }
}
