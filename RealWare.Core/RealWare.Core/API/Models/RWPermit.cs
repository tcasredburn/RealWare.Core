using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWPermit : RWBase
    {
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AccountNo
        {
            get;
            set;
        }

        public List<RWPermitApplicant> Applicants
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string AssignedTo
        {
            get;
            set;
        }

        public DateTime? CertificateOfOccupancyDate
        {
            get;
            set;
        }

        public RWPermitContractor Contractor
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ElectricProvider
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ElectricService
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string FemaType
        {
            get;
            set;
        }

        public List<RWPermitImpInventory> ImprovementInventories
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string IssuedBy
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public RWPermitLender Lender
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string LocalPermitNo
        {
            get;
            set;
        }

        public List<RWNote> Notes
        {
            get;
            set;
        }

        [StringLength(60, ErrorMessage = "Value cannot be longer than 60 characters.")]
        public string OwnerName
        {
            get;
            set;
        }

        [StringLength(18, ErrorMessage = "Value cannot be longer than 18 characters.")]
        public string OwnerPhoneNumber
        {
            get;
            set;
        }

        public bool PermitActiveFlag
        {
            get;
            set;
        }

        public decimal? PermitAmount
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string PermitBatchNumber
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitClassification
        {
            get;
            set;
        }

        public DateTime? PermitDate
        {
            get;
            set;
        }

        public DateTime? PermitExpirationDate
        {
            get;
            set;
        }

        public decimal? PermitFee
        {
            get;
            set;
        }

        public string PermitNo
        {
            get;
            set;
        }

        public DateTime? PermitOD0
        {
            get;
            set;
        }

        public DateTime? PermitOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitOM1
        {
            get;
            set;
        }

        public decimal? PermitON0
        {
            get;
            set;
        }

        public decimal? PermitON1
        {
            get;
            set;
        }

        public decimal? PermitON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitOT1
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string PermitPriority
        {
            get;
            set;
        }

        [StringLength(500, ErrorMessage = "Value cannot be longer than 500 characters.")]
        public string PermitReason
        {
            get;
            set;
        }

        [StringLength(1000, ErrorMessage = "Value cannot be longer than 1000 characters.")]
        public string PermitReasonDetail
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitSource
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string PermitStatus
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PermitType
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string PermitUse
        {
            get;
            set;
        }

        public DateTime? PermitWorkDate
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string PermitWorkedBy
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PlannersApproval
        {
            get;
            set;
        }

        public decimal? PrimaryImpNo
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string SepticPermitNo
        {
            get;
            set;
        }

        public List<RWPermitUtilityProvider> UtilityProviders
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string ValueChangeAppliedTo
        {
            get;
            set;
        }

        public int? ValueChangeTaxYear
        {
            get;
            set;
        }

        public decimal? ValueChangeValue
        {
            get;
            set;
        }

        public List<RWPermitVariance> Variances
        {
            get;
            set;
        }

        public RWPermit()
        {
            Applicants = new List<RWPermitApplicant>();
            ImprovementInventories = new List<RWPermitImpInventory>();
            UtilityProviders = new List<RWPermitUtilityProvider>();
            Variances = new List<RWPermitVariance>();
            Notes = new List<RWNote>();
        }
    }
}
