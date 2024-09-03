using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWLegal : RWBase
    {
        public DateTime? AcctLegalOD0
        {
            get;
            set;
        }

        public DateTime? AcctLegalOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctLegalOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctLegalOM1
        {
            get;
            set;
        }

        public decimal? AcctLegalON0
        {
            get;
            set;
        }

        public decimal? AcctLegalON1
        {
            get;
            set;
        }

        public decimal? AcctLegalON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctLegalOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctLegalOT1
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public string LegalText
        {
            get;
            set;
        }

        [StringLength(255, ErrorMessage = "Value cannot be longer than 255 characters.")]
        public string ShortDescription
        {
            get;
            set;
        }

        public RWLegal()
        {
        }
    }
}
