using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Improvement
{
    public class RWImprovementOccupancy : RWBase
    {
        [StringLength(5, ErrorMessage = "Value cannot be longer than 5 characters.")]
        public string AbstractAdjCode
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string AbstractCode
        {
            get;
            set;
        }

        public DateTime? AbstractInDate
        {
            get;
            set;
        }

        public DateTime? AbstractOutDate
        {
            get;
            set;
        }

        public long? BltAsUnitCountOverride
        {
            get;
            set;
        }

        public long? DetailID
        {
            get;
            set;
        }

        public decimal? ImpAbstractValue
        {
            get;
            set;
        }

        public long? ImpBltAsOtherOverride
        {
            get;
            set;
        }

        public long? ImpSFOverride
        {
            get;
            set;
        }

        public DateTime? ImpsOccOD0
        {
            get;
            set;
        }

        public DateTime? ImpsOccOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsOcCOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsOcCOM1
        {
            get;
            set;
        }

        public decimal? ImpsOccON0
        {
            get;
            set;
        }

        public decimal? ImpsOccON1
        {
            get;
            set;
        }

        public decimal? ImpsOccON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsOccOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsOccOT1
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public bool MarketValueOverrideFlag
        {
            get;
            set;
        }

        [Required]
        public long OccCode
        {
            get;
            set;
        }

        public decimal OccCompletedPct
        {
            get;
            set;
        }

        [Required]
        public decimal OccPercent
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ProrateType
        {
            get;
            set;
        }

        public int? RoomCountOverride
        {
            get;
            set;
        }

        [Required]
        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string TaxDistrict
        {
            get;
            set;
        }

        public RWImprovementOccupancy()
        {
        }
    }
}
