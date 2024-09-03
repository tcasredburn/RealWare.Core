using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWAppeal : RWBase
    {
        public long? AgentCode
        {
            get;
            set;
        }

        public List<RWAppealAccount> AppealAccounts
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AppealActionCode
        {
            get;
            set;
        }

        public DateTime? AppealActionDate
        {
            get;
            set;
        }

        public long? AppealAdjustDenyReasonID
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AppealBasis
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AppealDecision
        {
            get;
            set;
        }

        public decimal? AppealEndValue
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AppealMethod
        {
            get;
            set;
        }

        public long? AppealNo
        {
            get;
            set;
        }

        public DateTime? Appealod0
        {
            get;
            set;
        }

        public DateTime? Appealod1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string Appealom0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string Appealom1
        {
            get;
            set;
        }

        public decimal? Appealon0
        {
            get;
            set;
        }

        public decimal? Appealon1
        {
            get;
            set;
        }

        public decimal? Appealon2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string Appealot0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string Appealot1
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AppealReason
        {
            get;
            set;
        }

        [StringLength(1000, ErrorMessage = "Value cannot be longer than 1000 characters.")]
        public string AppealReasonDescription
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AppealRecommendation
        {
            get;
            set;
        }

        public long? AppealStatusID
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AppealType
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AppointmentColor
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AppraisalType
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string AssignedTo
        {
            get;
            set;
        }

        public decimal? BeginningAppealValue
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string CaseNo
        {
            get;
            set;
        }

        public DateTime? DateOfAppeal
        {
            get;
            set;
        }

        public DateTime? DateReceived
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string DecisionBy
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string InitiatedBy
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string Mailto
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string PrimaryAccount
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ReReViewDecision
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ReReViewInitials
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ReReViewStatus
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ScheduleAppraiserinitials
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ScheduleBoardFileNo
        {
            get;
            set;
        }

        public long? ScheduleBoardID
        {
            get;
            set;
        }

        [StringLength(500, ErrorMessage = "Value cannot be longer than 500 characters.")]
        public string ScheduleComment
        {
            get;
            set;
        }

        public DateTime? ScheduleDate
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ScheduleEndTime
        {
            get;
            set;
        }

        public long? ScheduleLocationID
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ScheduleStartTime
        {
            get;
            set;
        }

        public DateTime? TaxPayermeetingDate
        {
            get;
            set;
        }

        public bool? TaxPayermeetingRequestFlag
        {
            get;
            set;
        }

        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string TaxPayermeetingTime
        {
            get;
            set;
        }

        [Required]
        public int TaxYear
        {
            get;
            set;
        }

        public DateTime? WriteDate
        {
            get;
            set;
        }

        public RWAppeal()
        {
            AppealAccounts = new List<RWAppealAccount>();
        }
    }
}
