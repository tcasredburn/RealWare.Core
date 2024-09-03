using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Sale
{
    public class RWSaleAffidavit : RWBase
    {
        [StringLength(3, ErrorMessage = "Value cannot be longer than 3 characters.")]
        public string AssessorInitials
        {
            get;
            set;
        }

        public RWContactInformation ContactInformation
        {
            get;
            set;
        }

        [StringLength(3, ErrorMessage = "Value cannot be longer than 3 characters.")]
        public string DepartmentOfRevenueInitials
        {
            get;
            set;
        }

        [Required]
        public RWDetailTypes DetailTypes
        {
            get;
            set;
        }

        public bool DivideParcelFlag
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string DocketNo
        {
            get;
            set;
        }

        public DateTime? DocumentDate
        {
            get;
            set;
        }

        public decimal DownPaymentAmount
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ExcludeCode1
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ExcludeCode2
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string ExcludeDescription1
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string ExcludeDescription2
        {
            get;
            set;
        }

        [StringLength(4000, ErrorMessage = "Value cannot be longer than 4000 characters.")]
        public string LegalDescription
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string Page
        {
            get;
            set;
        }

        public List<RWSaleAffidavitParcel> Parcels
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string PartialInterestDescription
        {
            get;
            set;
        }

        public bool PartialInterestFlag
        {
            get;
            set;
        }

        public decimal PPAdjAmount
        {
            get;
            set;
        }

        [StringLength(200, ErrorMessage = "Value cannot be longer than 200 characters.")]
        public string PPDescription
        {
            get;
            set;
        }

        public bool PPFlag
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string PrimaryUseCode
        {
            get;
            set;
        }

        public RWPropertyAddress PropertyAddress
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ReceptionNo
        {
            get;
            set;
        }

        public bool RelatedFlag
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string RelatedType
        {
            get;
            set;
        }

        public DateTime? SaleAffidavitOD0
        {
            get;
            set;
        }

        public DateTime? SaleAffidavitOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAffidavitOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAffidavitOM1
        {
            get;
            set;
        }

        public decimal? SaleAffidavitON0
        {
            get;
            set;
        }

        public decimal? SaleAffidavitON1
        {
            get;
            set;
        }

        public decimal? SaleAffidavitON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAffidavitOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleAffidavitOT1
        {
            get;
            set;
        }

        public DateTime? SaleDate
        {
            get;
            set;
        }

        public decimal Saleprice
        {
            get;
            set;
        }

        [StringLength(3, ErrorMessage = "Value cannot be longer than 3 characters.")]
        public string SalesAffBatchNo
        {
            get;
            set;
        }

        public decimal TotalAdjActualValue
        {
            get;
            set;
        }

        public decimal? UnitCount
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ValueAreaCode
        {
            get;
            set;
        }

        public DateTime? WriteDate
        {
            get;
            set;
        }

        public RWSaleAffidavit()
        {
            Parcels = new List<RWSaleAffidavitParcel>();
            PropertyAddress = new RWPropertyAddress();
            DetailTypes = new RWDetailTypes();
            ContactInformation = new RWContactInformation();
        }
    }
}
