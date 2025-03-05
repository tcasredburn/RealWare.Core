using System;

namespace RealWare.Core.Database.Models.Encompass.Table
{
    public class AppealDto : Base.RealWareDtoBase
    {
        public decimal VerStart { get; set; }
        public decimal VerEnd { get; set; }
        public decimal TaxYear { get; set; }
        public decimal AppealNo { get; set; }
        public string AppealType { get; set; }
        public string AppealMethod { get; set; }
        public string AssignedTo { get; set; }
        public string AgentCode { get; set; }
        public string MailTo { get; set; }
        public string CaseNo { get; set; }
        public string ReviewStatus { get; set; }
        public string ReReviewInitials { get; set; }
        public string ReReviewDecision { get; set; }
        public string AppealReason { get; set; }
        public string AppealBasis { get; set; }
        public string AppealRecommendation { get; set; }
        public decimal? AppealAdjustDenyReasonId { get; set; }
        public decimal? AppealEndValue { get; set; }
        public DateTime? DateOfAppeal { get; set; }
        public DateTime? DateReceived { get; set; }
        public bool TaxpayerMeetingRequestFlag { get; set; }
        public DateTime? TaxpayerMeetingDate { get; set; }
        public string TaxpayerMeetingTime { get; set; }
        public decimal? BeginningAppealValue { get; set; }
        public decimal? AppealON1 { get; set; }
        public decimal? AppealON2 { get; set; }
        public DateTime? AppealOD0 { get; set; }
        public DateTime? AppealOD1 { get; set; }
        public string AppealOM0 { get; set; }
        public string AppealOM1 { get; set; }
        public string AppealOT0 { get; set; }
        public string AppealOT1 { get; set; }
        public string AppraisalType { get; set; }
        public string PrimaryAccount { get; set; }
        public decimal JurisdictionId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public string ScheduleStartTime { get; set; }
        public string ScheduleEndTime { get; set; }
        public string ScheduleComment { get; set; }
        public string ScheduleBoardFileNo { get; set; }
        public string ScheduleAppraiserInitials { get; set; }
        public string AppointmentColor { get; set; }
        public DateTime? WriteDate { get; set; }
        public decimal SeqId { get; set; }
        public string AppealActionCode { get; set; }
        public DateTime? AppealActionDate { get; set; }
        public decimal? AppealStatusId { get; set; }
        public string AppealReasonDescription { get; set; }
        public string AppealDecision { get; set; }
        public decimal? ScheduleBoardId { get; set; }
        public decimal? ScheduleLocationId { get; set; }
    }
}
