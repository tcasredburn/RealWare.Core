using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWLandAbstract : RWBase, ILandAbstract
    {
        [StringLength(5, ErrorMessage = "Value cannot be longer than 5 characters.")]
        public string AbstractAdjCode
        {
            get;
            set;
        }

        [Required]
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

        public bool AttributeAdjFlag
        {
            get;
            set;
        }

        public long? DetailID
        {
            get;
            set;
        }

        public DateTime? LandAbstractOD0
        {
            get;
            set;
        }

        public DateTime? LandAbstractOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LandAbstractOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LandAbstractOM1
        {
            get;
            set;
        }

        public decimal? LandAbstractON0
        {
            get;
            set;
        }

        public decimal? LandAbstractON1
        {
            get;
            set;
        }

        public decimal? LandAbstractON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LandAbstractOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LandAbstractOT1
        {
            get;
            set;
        }

        public decimal? LandAcres
        {
            get;
            set;
        }

        public bool LandactiveFlag
        {
            get;
            set;
        }

        public decimal? LandActualTotal
        {
            get;
            set;
        }

        public decimal? LandAdjSize
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string LandClass
        {
            get;
            set;
        }

        public decimal? LandFF
        {
            get;
            set;
        }

        public decimal? LandOverrideAdjSize
        {
            get;
            set;
        }

        public bool LandOverrideFlag
        {
            get;
            set;
        }

        public decimal? LandOverrideTotal
        {
            get;
            set;
        }

        public decimal LandOverrideValuePer
        {
            get;
            set;
        }

        public decimal? LandSF
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string LandSubClass
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string LandType
        {
            get;
            set;
        }

        public decimal? LandUnitCount
        {
            get;
            set;
        }

        public decimal? LandValue
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

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string LandValueMeasure
        {
            get;
            set;
        }

        public decimal LandValuePer
        {
            get;
            set;
        }

        public decimal? LandValuePerAdjFactor
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string LEA
        {
            get;
            set;
        }

        public decimal? MSALandValue
        {
            get;
            set;
        }

        public decimal? MSALandValuePer
        {
            get;
            set;
        }

        public decimal? NCTotalActualValue
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

        [Required]
        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string TaxDistrict
        {
            get;
            set;
        }

        public RWLandAbstract()
        {
        }
    }
}
