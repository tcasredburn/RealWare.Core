using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Sale
{
    public class RWSaleInventoryDetail : RWBase
    {
        [Required]
        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string DetailType
        {
            get;
            set;
        }

        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string InventoryDetailDescription
        {
            get;
            set;
        }

        public long? InventoryDetailID
        {
            get;
            set;
        }

        [Required]
        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string InventoryDetailType
        {
            get;
            set;
        }

        public decimal InventoryUnitCount
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public DateTime? SaleInventoryDetailOD0
        {
            get;
            set;
        }

        public DateTime? SaleInventoryDetailOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleInventoryDetailOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleInventoryDetailOM1
        {
            get;
            set;
        }

        public decimal? SaleInventoryDetailON0
        {
            get;
            set;
        }

        public decimal? SaleInventoryDetailON1
        {
            get;
            set;
        }

        public decimal? SaleInventoryDetailON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleInventoryDetailOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleInventoryDetailOT1
        {
            get;
            set;
        }

        public int? YearBuilt
        {
            get;
            set;
        }

        public RWSaleInventoryDetail()
        {
        }
    }
}
