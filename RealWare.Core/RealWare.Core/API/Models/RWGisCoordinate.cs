using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWGisCoordinate : RWBase
    {
        public decimal? Altitude
        {
            get;
            set;
        }

        public DateTime? GisCoordinateOD0
        {
            get;
            set;
        }

        public DateTime? GisCoordinateOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GisCoordinateOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GisCoordinateOM1
        {
            get;
            set;
        }

        public decimal? GisCoordinateON0
        {
            get;
            set;
        }

        public decimal? GisCoordinateON1
        {
            get;
            set;
        }

        public decimal? GisCoordinateON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GisCoordinateOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GisCoordinateOT1
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string GisDescription
        {
            get;
            set;
        }

        public decimal? Latitude
        {
            get;
            set;
        }

        public long? LocationID
        {
            get;
            set;
        }

        public decimal? Longitude
        {
            get;
            set;
        }

        public DateTime? WriteDate
        {
            get;
            set;
        }

        public RWGisCoordinate()
        {
        }
    }
}
