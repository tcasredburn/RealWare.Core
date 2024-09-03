using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWFlag : RWBase
    {
        public long? DetailID
        {
            get;
            set;
        }

        public DateTime? EndDate
        {
            get;
            set;
        }

        public DateTime? FlagOD0
        {
            get;
            set;
        }

        public DateTime? FlagOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string FlagOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string FlagOM1
        {
            get;
            set;
        }

        public decimal? FlagON0
        {
            get;
            set;
        }

        public decimal? FlagON1
        {
            get;
            set;
        }

        public decimal? FlagON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string FlagOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string FlagOT1
        {
            get;
            set;
        }

        [Required]
        [StringLength(12, ErrorMessage = "Value cannot be longer than 12 characters.")]
        public string FlagType
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string KeyField
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string KeyValue
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public DateTime? StartDate
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string TifTaxAuthority
        {
            get;
            set;
        }

        public decimal? UnitCount
        {
            get;
            set;
        }

        public RWFlag()
        {
        }
    }
}
