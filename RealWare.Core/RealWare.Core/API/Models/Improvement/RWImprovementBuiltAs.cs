using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Improvement
{
    public class RWImprovementBuiltAs : RWBase
    {
        public long? ApexID
        {
            get;
            set;
        }

        public decimal? BathCount
        {
            get;
            set;
        }

        public decimal? BedroomCount
        {
            get;
            set;
        }

        [Required]
        public long BltAsCode
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string BltAsFoundation
        {
            get;
            set;
        }

        public long? BltAsHeight
        {
            get;
            set;
        }

        public long? BltAsHorsepower
        {
            get;
            set;
        }

        public long? BltAsLength
        {
            get;
            set;
        }

        public long? BltAsSF
        {
            get;
            set;
        }

        public decimal? BltAsStories
        {
            get;
            set;
        }

        public long? BltAsStoryHeight
        {
            get;
            set;
        }

        public long? BltAsTotalUnitCount
        {
            get;
            set;
        }

        public long? BltAsWidth
        {
            get;
            set;
        }

        public int? BltAsYearBuilt
        {
            get;
            set;
        }

        public long? Capacity
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ClassCode
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string Climate
        {
            get;
            set;
        }

        public long? DetailID
        {
            get;
            set;
        }

        public long? Diameter
        {
            get;
            set;
        }

        public int? EffectiveAge
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string FloorCover
        {
            get;
            set;
        }

        public List<RWImprovementBuiltAsFloor> Floors
        {
            get;
            set;
        }

        public decimal? HvacPercent
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string HvacType
        {
            get;
            set;
        }

        public long? ImpBltAsOther
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpExterior
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ImpInterior
        {
            get;
            set;
        }

        public DateTime? ImpsBltAsOD0
        {
            get;
            set;
        }

        public DateTime? ImpsBltAsOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsOM1
        {
            get;
            set;
        }

        public decimal? ImpsBltAsON0
        {
            get;
            set;
        }

        public decimal? ImpsBltAsON1
        {
            get;
            set;
        }

        public decimal? ImpsBltAsON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsBltAsOT1
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string MHDeprCode
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string MHmake
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string MHModelName
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string MHSkirt
        {
            get;
            set;
        }

        public long? MHSkirtLinearFeet
        {
            get;
            set;
        }

        public long? MHTagLength
        {
            get;
            set;
        }

        public long? MHTagWidth
        {
            get;
            set;
        }

        [StringLength(32, ErrorMessage = "Value cannot be longer than 32 characters.")]
        public string MHWallType
        {
            get;
            set;
        }

        public int? PrimaryBltAsOrderNo
        {
            get;
            set;
        }

        public decimal? RemodeledPercent
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string RoofCover
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string RoofType
        {
            get;
            set;
        }

        public int? RoomCount
        {
            get;
            set;
        }

        public long? SprinklerSF
        {
            get;
            set;
        }

        public List<RWImprovementBuiltAsUnit> Units
        {
            get;
            set;
        }

        public int? YearRemodeled
        {
            get;
            set;
        }

        public RWImprovementBuiltAs()
        {
            Floors = new List<RWImprovementBuiltAsFloor>();
            Units = new List<RWImprovementBuiltAsUnit>();
        }
    }
}
