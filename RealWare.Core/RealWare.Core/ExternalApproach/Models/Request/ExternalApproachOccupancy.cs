﻿using System;

namespace RealWare.Core.ExternalApproach.Models.Request
{
    public class ExternalApproachOccupancy
    {
        public int DetailId { get; set; }
        public string AccountNo { get; set; }
        public double ImpNo { get; set; }
        public int OccCode { get; set; }
        public double OccPercent { get; set; }
        public string AbstractCode { get; set; }
        public double ImpAbstractValue { get; set; }
        public object AbstractInDate { get; set; }
        public object AbstractOutDate { get; set; }
        public string AbstractAdjCode { get; set; }
        public string ProrateType { get; set; }
        public string TaxDistrict { get; set; }
        public string ImpsOccot0 { get; set; }
        public string ImpsOccot1 { get; set; }
        public string ImpsOcCom0 { get; set; }
        public string ImpsOcCom1 { get; set; }
        public object ImpsOccod0 { get; set; }
        public object ImpsOccod1 { get; set; }
        public double ImpsOccon0 { get; set; }
        public double ImpsOccon1 { get; set; }
        public double ImpsOccon2 { get; set; }
        public DateTime WriteDate { get; set; }
        public double OccCompletedPct { get; set; }
        public int SeqId { get; set; }
        public object RoomCountOverride { get; set; }
        public object BltAsUnitCountOverride { get; set; }
        public object ImpsfOverride { get; set; }
        public object ImpBltAsOtherOverride { get; set; }
        public int MarketValueOverrideFlag { get; set; }
    }
}
