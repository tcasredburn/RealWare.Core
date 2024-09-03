using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWAddress : RWBase
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

        [Required]
        public bool AddressValidFlag
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

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string PostalCode
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

        public DateTime? WriteDate
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

        public RWAddress()
        {
        }
    }
}
