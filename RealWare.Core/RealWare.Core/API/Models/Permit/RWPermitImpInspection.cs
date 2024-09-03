using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Permit
{
    public class RWPermitImpInspection : RWBase
    {
        public long? DetailID
        {
            get;
            set;
        }

        public DateTime? InspectDate
        {
            get;
            set;
        }

        [Required]
        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string InspectionType
        {
            get;
            set;
        }

        [Required]
        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string Inspector
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public bool PassFlag
        {
            get;
            set;
        }

        public DateTime? PermitImpInspectionOD0
        {
            get;
            set;
        }

        public DateTime? PermitImpInspectionOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInspectionOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInspectionOM1
        {
            get;
            set;
        }

        public decimal? PermitImpInspectionON0
        {
            get;
            set;
        }

        public decimal? PermitImpInspectionON1
        {
            get;
            set;
        }

        public decimal? PermitImpInspectionON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInspectionOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInspectionOT1
        {
            get;
            set;
        }

        public RWPermitImpInspection()
        {
        }
    }
}
