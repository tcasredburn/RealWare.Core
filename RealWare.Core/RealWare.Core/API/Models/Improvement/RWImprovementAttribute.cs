using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Improvement
{
    public class RWImprovementAttribute : RWBase
    {
        [Required]
        public decimal ImpAttributeAdjustment
        {
            get;
            set;
        }

        public DateTime? ImpsAttributeOD0
        {
            get;
            set;
        }

        public DateTime? ImpsAttributeOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsAttributeOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsAttributeOM1
        {
            get;
            set;
        }

        public decimal? ImpsAttributeON0
        {
            get;
            set;
        }

        public decimal? ImpsAttributeON1
        {
            get;
            set;
        }

        public decimal? ImpsAttributeON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsAttributeOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsAttributeOT1
        {
            get;
            set;
        }

        [Required]
        public long ImpsAttributeTypeID
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public RWImprovementAttribute()
        {
        }
    }
}
