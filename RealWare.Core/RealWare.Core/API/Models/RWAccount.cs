using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWAccount : RWBase
    {
        public DateTime? AcctDateCreated
        {
            get;
            set;
        }

        public DateTime? AcctOD0
        {
            get;
            set;
        }

        public DateTime? AcctOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctOM1
        {
            get;
            set;
        }

        public decimal? AcctON0
        {
            get;
            set;
        }

        public decimal? AcctON1
        {
            get;
            set;
        }

        public decimal? AcctON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctOT1
        {
            get;
            set;
        }

        [Required]
        [StringLength(1, ErrorMessage = "Value cannot be longer than 1 characters.")]
        public string AcctStatusCode
        {
            get;
            set;
        }

        [Required]
        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string AcctType
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AppraisalType
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

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AssociatedAcct
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string BusinessLicense
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

        public decimal? CensusBlock
        {
            get;
            set;
        }

        public decimal? CensusTract
        {
            get;
            set;
        }

        [StringLength(5, ErrorMessage = "Value cannot be longer than 5 characters.")]
        public string ControlMap
        {
            get;
            set;
        }

        public decimal? CostHybridPercent
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string DefaultApproachType
        {
            get;
            set;
        }

        [Required]
        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string DefaultTaxDistrict
        {
            get;
            set;
        }

        public DateTime? DetailedReviewDate
        {
            get;
            set;
        }

        [Required]
        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string EconomicAreaCode
        {
            get;
            set;
        }

        public bool? EFileFlag
        {
            get;
            set;
        }

        public List<RWFlag> Flags
        {
            get;
            set;
        }

        public decimal? IncomeHybridPercent
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public RWLegal Legal
        {
            get;
            set;
        }

        public List<RWLegalLocation> LegalLocations
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string LocalNo
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string MapGroup
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string MapNo
        {
            get;
            set;
        }

        public decimal? MarketHybridPercent
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string MobileHomeSpace
        {
            get;
            set;
        }

        public List<RWNote> Notes
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ParcelNo
        {
            get;
            set;
        }

        public int ParcelSequence
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

        public List<RWAccountPropertyAddress> PropertyAddresses
        {
            get;
            set;
        }

        public long? PropertyClassID
        {
            get;
            set;
        }

        [StringLength(1, ErrorMessage = "Value cannot be longer than 1 characters.")]
        public string PropertyIdentifier
        {
            get;
            set;
        }

        public decimal? ReconciledHybridPercent
        {
            get;
            set;
        }

        [StringLength(3, ErrorMessage = "Value cannot be longer than 3 characters.")]
        public string SpecialInterestNumber
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string StrippedAccountNo
        {
            get;
            set;
        }

        [Required]
        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ValueAreaCode
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string Ward
        {
            get;
            set;
        }

        public RWAccount()
        {
            PropertyAddresses = new List<RWAccountPropertyAddress>();
            LegalLocations = new List<RWLegalLocation>();
            Notes = new List<RWNote>();
            Flags = new List<RWFlag>();
        }
    }
}
