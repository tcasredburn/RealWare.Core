using System;

namespace RealWare.Core.ExternalApproach.Models.Request
{
    public class ExternalApproachFloor
    {
        public int DetailId { get; set; }
        public string AccountNo { get; set; }
        public double ImpNo { get; set; }
        public int BltAsCode { get; set; }
        public string ImpsFloorDescription { get; set; }
        public long? BltAsFloorsf { get; set; }
        public long? StoryHeight { get; set; }
        public long BltAsDetailId { get; set; }
        public string ImpsBltAsFloorot0 { get; set; }
        public string ImpsBltAsFloorot1 { get; set; }
        public string ImpsBltAsFloorom0 { get; set; }
        public string ImpsBltAsFloorom1 { get; set; }
        public DateTime? ImpsBltAsFloorod0 { get; set; }
        public DateTime? ImpsBltAsFloorod1 { get; set; }
        public double? ImpsBltAsFlooron0 { get; set; }
        public double? ImpsBltAsFlooron1 { get; set; }
        public double? ImpsBltAsFlooron2 { get; set; }
        public DateTime? WriteDate { get; set; }
        public int? ApexLinkFlag { get; set; }
        public long SeqId { get; set; }
        public long? ApexId { get; set; }
    }
}
