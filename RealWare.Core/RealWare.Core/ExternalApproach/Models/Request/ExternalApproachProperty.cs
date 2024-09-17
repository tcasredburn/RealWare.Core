﻿using System;
using System.Collections.Generic;

namespace RealWare.Core.ExternalApproach.Models.Request
{
    public class ExternalApproachProperty
    {
        public string AccountNo { get; set; }
        public double ImpNo { get; set; }
        public string ImpDescription { get; set; }
        public string CostValueBy { get; set; }
        public string MarketValueBy { get; set; }
        public string IncomeValueBy { get; set; }
        public double LandAttributedPct { get; set; }
        public double ImpCompletedPct { get; set; }
        public string ImpQuality { get; set; }
        public string ImpUnitType { get; set; }
        public double ImpDesignAdjPct { get; set; }
        public double ImpExteriorAdjPct { get; set; }
        public double ImpPhysicalDeprPct { get; set; }
        public double FunctionalObsolescePct { get; set; }
        public double EconomicObsolescePct { get; set; }
        public double ImpOtherAdjPct { get; set; }
        public string MHTitleNo { get; set; }
        public string MHSerialNo { get; set; }
        public double? MHTotalLength { get; set; }
        public string MHDecalNo { get; set; }
        public string MHTagNo { get; set; }
        public string Appraiser { get; set; }
        public DateTime AppraisalDate { get; set; }
        public int OwnerOccupiedFlag { get; set; }
        public string CostMethod { get; set; }
        public string MarketMethod { get; set; }
        public string IncomeMethod { get; set; }
        public string ImpConditionType { get; set; }
        public double CondoLandPercent { get; set; }
        public int Impsf { get; set; }
        public double CondoImpPercent { get; set; }
        public int ImpPerimeter { get; set; }
        public double ImPInteriorAdjPct { get; set; }
        public int CondoImpsf { get; set; }
        public double ImpAmateurAdjPct { get; set; }
        public int ImpNetSf { get; set; }
        public string PropertyType { get; set; }
        public string ApproAchType { get; set; }
        public string Impsot0 { get; set; }
        public string Impsot1 { get; set; }
        public string Impsom0 { get; set; }
        public string Impsom1 { get; set; }
        public object Impsod0 { get; set; }
        public object Impsod1 { get; set; }
        public object Impson0 { get; set; }
        public object Impson1 { get; set; }
        public object Impson2 { get; set; }
        public DateTime WriteDate { get; set; }
        public int SeqId { get; set; }
        public List<ExternalApproachOccupancy> Occupancies { get; set; }
        public List<ExternalApproachBuiltAs> BuiltAs { get; set; }
        public List<object> Details { get; set; }
        public List<object> AddOns { get; set; }
        public List<object> UserDetails { get; set; }
        public List<object> DetachedGarages { get; set; }
    }
}