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
        public int BltAsFloorsf { get; set; }
        public int StoryHeight { get; set; }
        public int BltAsDetailId { get; set; }
        public string ImpsBltAsFloorot0 { get; set; }
        public string ImpsBltAsFloorot1 { get; set; }
        public string ImpsBltAsFloorom0 { get; set; }
        public string ImpsBltAsFloorom1 { get; set; }
        public object ImpsBltAsFloorod0 { get; set; }
        public object ImpsBltAsFloorod1 { get; set; }
        public double ImpsBltAsFlooron0 { get; set; }
        public double ImpsBltAsFlooron1 { get; set; }
        public double ImpsBltAsFlooron2 { get; set; }
        public DateTime WriteDate { get; set; }
        public int APexLinkFlag { get; set; }
        public int SeqId { get; set; }
        public object APexId { get; set; }
    }
}
