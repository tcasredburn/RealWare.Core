using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWPerson : RWBase
    {
        public string AltName1
        {
            get;
            set;
        }

        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string EmailAddress
        {
            get;
            set;
        }

        [StringLength(18, ErrorMessage = "Value cannot be longer than 18 characters.")]
        public string Fax
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string FederalIdNo
        {
            get;
            set;
        }

        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string MetaPhoneName1
        {
            get;
            set;
        }

        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string MetaPhoneName2
        {
            get;
            set;
        }

        [StringLength(18, ErrorMessage = "Value cannot be longer than 18 characters.")]
        public string Mobile
        {
            get;
            set;
        }

        [StringLength(60, ErrorMessage = "Value cannot be longer than 60 characters.")]
        public string Name1
        {
            get;
            set;
        }

        [StringLength(60, ErrorMessage = "Value cannot be longer than 60 characters.")]
        public string Name2
        {
            get;
            set;
        }

        [StringLength(18, ErrorMessage = "Value cannot be longer than 18 characters.")]
        public string Pager
        {
            get;
            set;
        }

        public long? PersonCode
        {
            get;
            set;
        }

        [StringLength(60, ErrorMessage = "Value cannot be longer than 60 characters.")]
        public DateTime? PersonOD0
        {
            get;
            set;
        }

        public DateTime? PersonOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PersonOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PersonOM1
        {
            get;
            set;
        }

        public decimal? PersonON0
        {
            get;
            set;
        }

        public decimal? PersonON1
        {
            get;
            set;
        }

        public decimal? PersonON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PersonOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PersonOT1
        {
            get;
            set;
        }

        [StringLength(18, ErrorMessage = "Value cannot be longer than 18 characters.")]
        public string Phone
        {
            get;
            set;
        }

        [Required]
        public bool PrivateFlag
        {
            get;
            set;
        }

        [Range(0, 999999999)]
        public long SSN
        {
            get;
            set;
        }

        public DateTime? WriteDate
        {
            get;
            set;
        }

        public RWPerson()
        {
        }
    }
}
