using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWAccountOwner : RWBase
    {
        public DateTime? AcctOwnerAddressOD0
        {
            get;
            set;
        }

        public DateTime? AcctOwnerAddressOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctOwnerAddressOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctOwnerAddressOM1
        {
            get;
            set;
        }

        public decimal? AcctOwnerAddressON0
        {
            get;
            set;
        }

        public decimal? AcctOwnerAddressON1
        {
            get;
            set;
        }

        public decimal? AcctOwnerAddressON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctOwnerAddressOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctOwnerAddressOT1
        {
            get;
            set;
        }

        public RWAddress Address
        {
            get;
            set;
        }

        [Required]
        public bool NotifyFlag
        {
            get;
            set;
        }

        [Range(0, 1)]
        [Required]
        public decimal OwnerPercent
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string OwnershipType
        {
            get;
            set;
        }

        [Required]
        public RWPerson Person
        {
            get;
            set;
        }

        [Required]
        public bool PrimaryOwnerFlag
        {
            get;
            set;
        }

        public DateTime? WriteDate
        {
            get;
            set;
        }

        public RWAccountOwner()
        {
            Person = new RWPerson();
            Address = new RWAddress();
        }
    }
}
