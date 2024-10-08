﻿using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWImprovementDetachedGarage : RWBase
    {
        public long? ApexID
        {
            get;
            set;
        }

        public bool ApexLinkFlag
        {
            get;
            set;
        }

        public decimal? CostRCN
        {
            get;
            set;
        }

        public decimal? CostRCNLD
        {
            get;
            set;
        }

        public decimal? CostUnitprice
        {
            get;
            set;
        }

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

        public int? DetailYearBuilt
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

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ImpDetailType
        {
            get;
            set;
        }

        [Required]
        public int ImpDetailTypeID
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

        public int? PhysicalAge
        {
            get;
            set;
        }

        public decimal? PhysicalDeprPct
        {
            get;
            set;
        }

        public decimal? PhysicalDeprValue
        {
            get;
            set;
        }

        public RWImprovementDetachedGarage()
        {
        }
    }
}
