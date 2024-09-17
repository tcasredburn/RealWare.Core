using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWPermitImpInventory : RWBase
    {
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ExteriorFinish
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string Floodplain
        {
            get;
            set;
        }

        public decimal? FrontSetBack
        {
            get;
            set;
        }

        [Required]
        public decimal ImpNo
        {
            get;
            set;
        }

        public List<RWPermitImpInspection> Inspections
        {
            get;
            set;
        }

        public List<RWPermitImpInventoryDetail> InventoryDetails
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string MHmake
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string MHModel
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string MHSerialNo
        {
            get;
            set;
        }

        public int? MHYearBuilt
        {
            get;
            set;
        }

        public DateTime? PermitImpInventoryOD0
        {
            get;
            set;
        }

        public DateTime? PermitImpInventoryOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInventoryOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInventoryOM1
        {
            get;
            set;
        }

        public decimal? PermitImpInventoryON0
        {
            get;
            set;
        }

        public decimal? PermitImpInventoryON1
        {
            get;
            set;
        }

        public decimal? PermitImpInventoryON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInventoryOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitImpInventoryOT1
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string PermitPropertyType
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string PlanModel
        {
            get;
            set;
        }

        public decimal? RearSetBack
        {
            get;
            set;
        }

        public decimal? RoadSetBack
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string Roofing
        {
            get;
            set;
        }

        public decimal? SideCornerSetBack
        {
            get;
            set;
        }

        public decimal? SideSetBack
        {
            get;
            set;
        }

        public decimal? TotalfrontSetBack
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ZoningCode
        {
            get;
            set;
        }

        public RWPermitImpInventory()
        {
            InventoryDetails = new List<RWPermitImpInventoryDetail>();
            Inspections = new List<RWPermitImpInspection>();
        }
    }
}
