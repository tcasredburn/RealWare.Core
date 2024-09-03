using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Permit
{
    public class RWPermitVariance : RWBase
    {
        public long? DetailID
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public DateTime? PermitVarianceOD0
        {
            get;
            set;
        }

        public DateTime? PermitVarianceOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitVarianceOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitVarianceOM1
        {
            get;
            set;
        }

        public decimal? PermitVarianceON0
        {
            get;
            set;
        }

        public decimal? PermitVarianceON1
        {
            get;
            set;
        }

        public decimal? PermitVarianceON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitVarianceOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitVarianceOT1
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string ResolutionNumber
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string VarianceType
        {
            get;
            set;
        }

        public RWPermitVariance()
        {
        }
    }
}
