using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Improvement
{
    public class RWImprovementBuiltAsFloor : RWBase
    {
        public long? ApexID
        {
            get;
            set;
        }

        public bool? ApexLinkFlag
        {
            get;
            set;
        }

        public long? BltAsDetailID
        {
            get;
            set;
        }

        public long? BltAsFloorSF
        {
            get;
            set;
        }

        public long? DetailID
        {
            get;
            set;
        }

        public DateTime? ImpsBltAsFloorOD0
        {
            get;
            set;
        }

        public DateTime? ImpsBltAsFloorOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsFloorOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsFloorOM1
        {
            get;
            set;
        }

        public decimal? ImpsBltAsFloorON0
        {
            get;
            set;
        }

        public decimal? ImpsBltAsFloorON1
        {
            get;
            set;
        }

        public decimal? ImpsBltAsFloorON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsFloorOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsFloorOT1
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ImpsFloorDescription
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public long? StoryHeight
        {
            get;
            set;
        }

        public RWImprovementBuiltAsFloor()
        {
        }
    }
}
