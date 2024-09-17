using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWImprovement : RWBase
    {
        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AccountNo
        {
            get;
            set;
        }

        public List<RWImprovementAddOn> AddOns
        {
            get;
            set;
        }

        public DateTime? AppraisalDate
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string Appraiser
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string ApproachType
        {
            get;
            set;
        }

        public List<RWImprovementAttribute> Attributes
        {
            get;
            set;
        }

        public List<RWImprovementBuiltAs> BuiltAs
        {
            get;
            set;
        }

        public decimal? CondoImpPercent
        {
            get;
            set;
        }

        public long? CondoImpSF
        {
            get;
            set;
        }

        public decimal? CondoLandPercent
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string CostMethod
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string CostValueBy
        {
            get;
            set;
        }

        public List<RWImprovementDetachedGarage> DetachedGarages
        {
            get;
            set;
        }

        public decimal? EconomicObsolescePct
        {
            get;
            set;
        }

        public decimal? FunctionalObsolescePct
        {
            get;
            set;
        }

        public List<RWImprovementGeneralDetail> GeneralDetails
        {
            get;
            set;
        }

        public decimal? ImpAmateurAdjPct
        {
            get;
            set;
        }

        public decimal? ImpCompletedPct
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string ImpConditionType
        {
            get;
            set;
        }

        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string ImpDescription
        {
            get;
            set;
        }

        public decimal? ImpDesignAdjPct
        {
            get;
            set;
        }

        public decimal? ImpExteriorAdjPct
        {
            get;
            set;
        }

        public decimal? ImpInteriorAdjPct
        {
            get;
            set;
        }

        public long? ImpNetSF
        {
            get;
            set;
        }

        [Required]
        public decimal ImpNo
        {
            get;
            set;
        }

        public decimal? ImpOtherAdjPct
        {
            get;
            set;
        }

        public long? ImpPerimeter
        {
            get;
            set;
        }

        public decimal? ImpPhysicalDeprPct
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string ImpQuality
        {
            get;
            set;
        }

        public RWImprovementValue ImprovementValue
        {
            get;
            set;
        }

        public long? ImpSF
        {
            get;
            set;
        }

        public DateTime? ImpsOD0
        {
            get;
            set;
        }

        public DateTime? ImpsOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsOM1
        {
            get;
            set;
        }

        public decimal? ImpsON0
        {
            get;
            set;
        }

        public decimal? ImpsON1
        {
            get;
            set;
        }

        public decimal? ImpsON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsOT1
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ImpUnitType
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string IncomeMethod
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string IncomeValueBy
        {
            get;
            set;
        }

        public decimal? LandAttributedPct
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
        public string MarketMethod
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string MarketValueBy
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string MHDecalNo
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string MHSerialNo
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string MHTagNo
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string MHTitleNo
        {
            get;
            set;
        }

        public long? MHTotalLength
        {
            get;
            set;
        }

        public List<RWImprovementOccupancy> Occupancies
        {
            get;
            set;
        }

        public bool OwnerOccupiedFlag
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string PropertyType
        {
            get;
            set;
        }

        public List<RWImprovementUserDetail> UserDetails
        {
            get;
            set;
        }

        public RWImprovement()
        {
            BuiltAs = new List<RWImprovementBuiltAs>();
            GeneralDetails = new List<RWImprovementGeneralDetail>();
            DetachedGarages = new List<RWImprovementDetachedGarage>();
            UserDetails = new List<RWImprovementUserDetail>();
            AddOns = new List<RWImprovementAddOn>();
            Attributes = new List<RWImprovementAttribute>();
            Occupancies = new List<RWImprovementOccupancy>();
            ImprovementValue = new RWImprovementValue();
        }
    }
}
