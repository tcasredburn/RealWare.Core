using System;
using System.Collections.Generic;

namespace RealWare.Core.ExternalApproach.Models.Request
{
    public class ExternalApproachBuiltAs
    {
        public int DetailId { get; set; }
        public string AccountNo { get; set; }
        public double ImpNo { get; set; }
        public int BltAsCode { get; set; }
        public double HvacPercent { get; set; }
        public string CLimate { get; set; }
        public string ImpExterior { get; set; }
        public string ImPInterior { get; set; }
        public double BltAsstories { get; set; }
        public int BltAsStoryHeight { get; set; }
        public string RoofType { get; set; }
        public string RoofCover { get; set; }
        public string FloorCover { get; set; }
        public string BltAsFoundation { get; set; }
        public int RoomCount { get; set; }
        public double BedroomCount { get; set; }
        public int BltAsTotalUnitCount { get; set; }
        public int ImpBltAsOther { get; set; }
        public string ClassCode { get; set; }
        public int Diameter { get; set; }
        public int Capacity { get; set; }
        public int BltAsHorsepower { get; set; }
        public int BltAsHeight { get; set; }
        public int BltAsYearBuilt { get; set; }
        public int YearreModeled { get; set; }
        public double ReModeledPercent { get; set; }
        public object EffectiveAge { get; set; }
        public int BltAsLength { get; set; }
        public int BltAsWidth { get; set; }
        public int MHTagLength { get; set; }
        public int MHTagWidth { get; set; }
        public string MHSkirt { get; set; }
        public int MHSkirtLinearFeet { get; set; }
        public string MHWallType { get; set; }
        public int BltAsSf { get; set; }
        public int SprinklerSf { get; set; }
        public double BathCount { get; set; }
        public int PrimaryBltAsOrderNo { get; set; }
        public string HvacType { get; set; }
        public string ImpsBltAsot0 { get; set; }
        public string ImpsBltAsot1 { get; set; }
        public string ImpsBltAsom0 { get; set; }
        public string ImpsBltAsom1 { get; set; }
        public object ImpsBltAsod0 { get; set; }
        public object ImpsBltAsod1 { get; set; }
        public double ImpsBltAson0 { get; set; }
        public double ImpsBltAson1 { get; set; }
        public double ImpsBltAson2 { get; set; }
        public DateTime WriteDate { get; set; }
        public string MHDeprCode { get; set; }
        public string MHmake { get; set; }
        public string MHModelName { get; set; }
        public int SeqId { get; set; }
        public object APexId { get; set; }
        public double ExternalCostValue { get; set; }
        public double MHExternalMakeId { get; set; }
        public double MHExternalModelId { get; set; }
        public List<ExternalApproachFloor> Floors { get; set; }
        public List<object> Units { get; set; }
    }
}
