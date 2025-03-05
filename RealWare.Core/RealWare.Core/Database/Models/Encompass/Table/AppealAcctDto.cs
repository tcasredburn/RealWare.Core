using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.Table
{
    public class AppealAcctDto : RealWareDtoBase
    {
        public decimal VerStart { get; set; }
        public decimal VerEnd { get; set; }
        public decimal TaxYear { get; set; }
        public decimal AppealNo { get; set; }
        public string AccountNo { get; set; }
        public decimal? AppealAdjustDenyReasonId { get; set; }
        public string AppealComment { get; set; }
        public decimal? AppealAccountEndValue { get; set; }
        public decimal? AppealAcctON0 { get; set; }
        public decimal? AppealAcctON1 { get; set; }
        public decimal? AppealAcctON2 { get; set; }
        public DateTime? AppealAcctOD0 { get; set; }
        public DateTime? AppealAcctOD1 { get; set; }
        public string AppealAcctOM0 { get; set; }
        public string AppealAcctOM1 { get; set; }
        public string AppealAcctOT0 { get; set; }
        public string AppealAcctOT1 { get; set; }
        public decimal JurisdictionId { get; set; }
        public string AppealDecision { get; set; }
        public DateTime? WriteDate { get; set; }
        public decimal? BeginningAccountValue { get; set; }
        public string AppealAcctReasonDesc { get; set; }
        public decimal? AddBroadAppealEndValue { get; set; }
        public decimal SeqId { get; set; }
        public decimal? NewTotalAppealValue { get; set; }
    }

}
