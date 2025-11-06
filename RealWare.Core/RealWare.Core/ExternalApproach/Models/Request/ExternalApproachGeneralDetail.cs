namespace RealWare.Core.ExternalApproach.Models.Request
{
    public class ExternalApproachGeneralDetail : ExternalApproachApexImpDetailBase
    {
        public decimal? CostMLPDeprPct { get; set; }
        public decimal? CostMLPDeprValue { get; set; }
        public decimal? CostMLPLD { get; set; }
        public decimal? DetailUnitCount { get; set; }
        public string ImpDetailType { get; set; }
        public int ImpDetailTypeID { get; set; }
    }
}
