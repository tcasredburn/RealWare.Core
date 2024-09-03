using System;
using System.ComponentModel.DataAnnotations;

namespace RealWare.Core.API.Models
{
    public class RWAccountPropertyAddress : RWPropertyAddress
    {
        public DateTime? AcctPropertyAddressOD0
        {
            get;
            set;
        }

        public DateTime? AcctPropertyAddressOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctPropertyAddressOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctPropertyAddressOM1
        {
            get;
            set;
        }

        public decimal? AcctPropertyAddressON0
        {
            get;
            set;
        }

        public decimal? AcctPropertyAddressON1
        {
            get;
            set;
        }

        public decimal? AcctPropertyAddressON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctPropertyAddressOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctPropertyAddressOT1
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string BuildingID
        {
            get;
            set;
        }

        [StringLength(255, ErrorMessage = "Value cannot be longer than 255 characters.")]
        public string BusinessName
        {
            get;
            set;
        }

        public RWGisCoordinate GisCoordinate
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [Required]
        public int OrderNo
        {
            get;
            set;
        }

        public long? PropertyAddressCode
        {
            get;
            set;
        }

        public RWAccountPropertyAddress()
        {
        }
    }
}
