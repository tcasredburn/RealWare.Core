using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWAppealAccount : RWBase
    {
        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AccountNo
        {
            get;
            set;
        }

        public decimal? AddBoardAppealEndValue
        {
            get;
            set;
        }

        public decimal? AppealAccountEndValue
        {
            get;
            set;
        }

        public DateTime? AppealAcctod0
        {
            get;
            set;
        }

        public DateTime? AppealAcctod1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AppealAcctom0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AppealAcctom1
        {
            get;
            set;
        }

        public decimal? AppealAccton0
        {
            get;
            set;
        }

        public decimal? AppealAccton1
        {
            get;
            set;
        }

        public decimal? AppealAccton2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AppealAcctot0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AppealAcctot1
        {
            get;
            set;
        }

        [StringLength(1000, ErrorMessage = "Value cannot be longer than 1000 characters.")]
        public string AppealAcctReasonDesc
        {
            get;
            set;
        }

        public long? AppealAdjustDenyReasonID
        {
            get;
            set;
        }

        [StringLength(255, ErrorMessage = "Value cannot be longer than 255 characters.")]
        public string AppealComment
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

        public decimal? BeginningAccountValue
        {
            get;
            set;
        }

        public decimal? NewTotalAppealValue
        {
            get;
            set;
        }

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

        public RWAppealAccount()
        {
        }
    }
}
