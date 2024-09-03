using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Improvement
{
    public class RWImprovementUserDetail : RWBase
    {
        public long? DetailID
        {
            get;
            set;
        }

        public decimal? DetailUnitCount
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpDetailDescription
        {
            get;
            set;
        }

        public DateTime? ImpsDetailOD0
        {
            get;
            set;
        }

        public DateTime? ImpsDetailOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsDetailOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsDetailOM1
        {
            get;
            set;
        }

        public decimal? ImpsDetailON0
        {
            get;
            set;
        }

        public decimal? ImpsDetailON1
        {
            get;
            set;
        }

        public decimal? ImpsDetailON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsDetailOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpsDetailOT1
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public RWImprovementUserDetail()
        {
        }
    }
}
