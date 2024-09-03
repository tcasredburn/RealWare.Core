using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Improvement
{
    public class RWImprovementValue : RWBase
    {
        public decimal? CostActualValue
        {
            get;
            set;
        }

        public decimal? CostAmateurAdjValue
        {
            get;
            set;
        }

        public decimal? CostConditionMultiplier
        {
            get;
            set;
        }

        public decimal? CostDesignAdjValue
        {
            get;
            set;
        }

        public decimal? CostEconomicObsValue
        {
            get;
            set;
        }

        public decimal? CostExteriorAdjValue
        {
            get;
            set;
        }

        public decimal? CostFunctionalObsValue
        {
            get;
            set;
        }

        public decimal? CostInteriorAdjValue
        {
            get;
            set;
        }

        public decimal? CostLandscapingValue
        {
            get;
            set;
        }

        public DateTime? CostLastCalcDate
        {
            get;
            set;
        }

        public decimal? CostMLP
        {
            get;
            set;
        }

        public decimal? CostMLPDeprPct
        {
            get;
            set;
        }

        public decimal? CostMLPDeprValue
        {
            get;
            set;
        }

        public decimal? CostMLPLD
        {
            get;
            set;
        }

        public decimal? CostOtherAdjValue
        {
            get;
            set;
        }

        public decimal? CostOverrideValue
        {
            get;
            set;
        }

        public decimal? CostPhysicalDeprPct
        {
            get;
            set;
        }

        public decimal? CostPhysicalDeprValue
        {
            get;
            set;
        }

        public decimal? CostPlumbingTotalAdjValue
        {
            get;
            set;
        }

        public decimal? CostPropertyTypeAdjustment
        {
            get;
            set;
        }

        public decimal? CostQualityAdjustment
        {
            get;
            set;
        }

        public decimal? CostRCN
        {
            get;
            set;
        }

        public decimal? CostRCNLD
        {
            get;
            set;
        }

        public decimal? CostRoughInTotalAdjValue
        {
            get;
            set;
        }

        public decimal? CostValuePer
        {
            get;
            set;
        }

        public decimal? ExternalIncomeValue
        {
            get;
            set;
        }

        public decimal? ExternalMarketValue
        {
            get;
            set;
        }

        public decimal? ImpActualValue
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

        public DateTime? ImpsValueOD0
        {
            get;
            set;
        }

        public DateTime? ImpsValueOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsValueOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsValueOM1
        {
            get;
            set;
        }

        public decimal? ImpsValueON0
        {
            get;
            set;
        }

        public decimal? ImpsValueON1
        {
            get;
            set;
        }

        public decimal? ImpsValueON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsValueOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsValueOT1
        {
            get;
            set;
        }

        public decimal? IncomeActualValue
        {
            get;
            set;
        }

        public DateTime? IncomeLastCalcDate
        {
            get;
            set;
        }

        public decimal? IncomeOverrideValue
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public decimal? MarketActualValue
        {
            get;
            set;
        }

        public DateTime? MarketLastCalcDate
        {
            get;
            set;
        }

        public decimal? MarketMassValue
        {
            get;
            set;
        }

        public decimal? MarketOtherAdjValue
        {
            get;
            set;
        }

        public decimal? MarketOverrideValue
        {
            get;
            set;
        }

        public long MktRegressionOverrideValue
        {
            get;
            set;
        }

        public decimal? ReconcileImpValue
        {
            get;
            set;
        }

        public DateTime? ReconcileLastCalcDate
        {
            get;
            set;
        }

        public RWImprovementValue()
        {
        }
    }
}
