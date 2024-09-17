using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWSaleAffidavitParcel : RWBase
    {
        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AccountNo
        {
            get;
            set;
        }

        public string ParcelNo
        {
            get;
            set;
        }

        [Required]
        public int ParcelOrder
        {
            get;
            set;
        }

        public DateTime? SaleAffidavitParcelOD0
        {
            get;
            set;
        }

        public DateTime? SaleAffidavitParcelOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAffidavitParcelOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAffidavitParcelOM1
        {
            get;
            set;
        }

        public decimal? SaleAffidavitParcelON0
        {
            get;
            set;
        }

        public decimal? SaleAffidavitParcelON1
        {
            get;
            set;
        }

        public decimal? SaleAffidavitParcelON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAffidavitParcelOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAffidavitParcelOT1
        {
            get;
            set;
        }

        public DateTime? WriteDate
        {
            get;
            set;
        }

        public RWSaleAffidavitParcel()
        {
        }
    }
}
