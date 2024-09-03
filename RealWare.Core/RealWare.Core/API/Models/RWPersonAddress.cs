using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public abstract class RWPersonAddress : RWBase
    {
        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string Address1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string Address2
        {
            get;
            set;
        }

        public long? AddressCode
        {
            get;
            set;
        }

        public DateTime? AddressOD0
        {
            get;
            set;
        }

        public DateTime? AddressOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AddressOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AddressOM1
        {
            get;
            set;
        }

        public decimal? AddressON0
        {
            get;
            set;
        }

        public decimal? AddressON1
        {
            get;
            set;
        }

        public decimal? AddressON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AddressOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AddressOT1
        {
            get;
            set;
        }

        public bool AddressValidFlag
        {
            get;
            set;
        }

        [StringLength(60, ErrorMessage = "Value cannot be longer than 60 characters.")]
        public string AltName1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string City
        {
            get;
            set;
        }

        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string Country
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
        public string FederalIDNo
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

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string PostalCode
        {
            get;
            set;
        }

        public bool PrivateFlag
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string Province
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string StateCode
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string Zipcode
        {
            get;
            set;
        }

        protected RWPersonAddress()
        {
        }
    }
}
