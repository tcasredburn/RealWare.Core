using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWImprovementBuiltAsUnit : RWBase
    {
        public long? BltAsDetailID
        {
            get;
            set;
        }

        public long? BltAsUnitCount
        {
            get;
            set;
        }

        public long? DetailID
        {
            get;
            set;
        }

        [Required]
        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string IHPresentationType
        {
            get;
            set;
        }

        public DateTime? ImpsBltAsUnitOD0
        {
            get;
            set;
        }

        public DateTime? ImpsBltAsUnitOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsUnitOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsUnitOM1
        {
            get;
            set;
        }

        public decimal? ImpsBltAsUnitON0
        {
            get;
            set;
        }

        public decimal? ImpsBltAsUnitON1
        {
            get;
            set;
        }

        public decimal? ImpsBltAsUnitON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsUnitOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsUnitOT1
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string UnitType
        {
            get;
            set;
        }

        public RWImprovementBuiltAsUnit()
        {
        }
    }
}
