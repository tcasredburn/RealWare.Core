using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWLegalLocation : RWBase
    {
        public DateTime? AcctLegalLocationOD0
        {
            get;
            set;
        }

        public DateTime? AcctLegalLocationOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctLegalLocationOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctLegalLocationOM1
        {
            get;
            set;
        }

        public decimal? AcctLegalLocationON0
        {
            get;
            set;
        }

        public decimal? AcctLegalLocationON1
        {
            get;
            set;
        }

        public decimal? AcctLegalLocationON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctLegalLocationOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctLegalLocationOT1
        {
            get;
            set;
        }

        public long? DetailID
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string Governmentlot
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string Governmenttract
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [StringLength(500, ErrorMessage = "Value cannot be longer than 500 characters.")]
        public string LegalComment
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string Qtr
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string Qtrqtr
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string Range
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string Section
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string Township
        {
            get;
            set;
        }

        public RWLegalLocation()
        {
        }
    }
}
