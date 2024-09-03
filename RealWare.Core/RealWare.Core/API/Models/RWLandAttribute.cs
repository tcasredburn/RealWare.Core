using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWLandAttribute : RWBase
    {
        public decimal? AttributeAdjustment
        {
            get;
            set;
        }

        [Required]
        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AttributeSubType
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AttributeType
        {
            get;
            set;
        }

        public long? DetailID
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string FilterType
        {
            get;
            set;
        }

        public DateTime? LandAttributeOD0
        {
            get;
            set;
        }

        public DateTime? LandAttributeOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LandAttributeOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LandAttributeOM1
        {
            get;
            set;
        }

        public decimal? LandAttributeON0
        {
            get;
            set;
        }

        public decimal? LandAttributeON1
        {
            get;
            set;
        }

        public decimal? LandAttributeON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LandAttributeOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LandAttributeOT1
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string LandValueBy
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public RWLandAttribute()
        {
        }
    }
}
