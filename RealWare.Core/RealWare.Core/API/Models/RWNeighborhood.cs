using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWNeighborhood : RWBase
    {
        public DateTime? AcctNbhdOD0
        {
            get;
            set;
        }

        public DateTime? AcctNbhdOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctNbhdOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctNbhdOM1
        {
            get;
            set;
        }

        public decimal? AcctNbhdON0
        {
            get;
            set;
        }

        public decimal? AcctNbhdON1
        {
            get;
            set;
        }

        public decimal? AcctNbhdON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctNbhdOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctNbhdOT1
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public decimal? NbhdAdjustmentValue
        {
            get;
            set;
        }

        [Required]
        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdCode
        {
            get;
            set;
        }

        [Required]
        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdExtension
        {
            get;
            set;
        }

        [Required]
        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string PropertyType
        {
            get;
            set;
        }

        public RWNeighborhood()
        {
        }
    }
}
