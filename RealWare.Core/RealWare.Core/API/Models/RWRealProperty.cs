#if !v5

using RealWare.Core.API.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RealWare.Core.API.Models
{
    public class RWRealProperty : RWBase
    {
        [Required]
        public RWAccount Account
        {
            get;
            set;
        }

        [Required]
        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string AccountNo
        {
            get;
            set;
        }

        public DateTime? AcctRealOD0
        {
            get;
            set;
        }

        public DateTime? AcctRealOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctRealOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctRealOM1
        {
            get;
            set;
        }

        public decimal? AcctRealON0
        {
            get;
            set;
        }

        public decimal? AcctRealON1
        {
            get;
            set;
        }

        public decimal? AcctRealON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctRealOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string AcctRealOT1
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string DefaultLEA
        {
            get;
            set;
        }

        public long? FloodFringe
        {
            get;
            set;
        }

        public long? Floodway
        {
            get;
            set;
        }

        public bool ImpOnlyFlag
        {
            get;
            set;
        }

        public List<RWLandAbstract> LandAbstracts
        {
            get;
            set;
        }

        public DateTime? LandAppraisalDate
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string LandAppraiser
        {
            get;
            set;
        }

        public List<RWLandAttribute> LandAttributes
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string LandCertificationCode
        {
            get;
            set;
        }

        public long? LandDepth
        {
            get;
            set;
        }

        public decimal? LandEasementSF
        {
            get;
            set;
        }

        public decimal? LandExcessSF
        {
            get;
            set;
        }

        public decimal? LandGrossAcres
        {
            get;
            set;
        }

        public decimal? LandGrossFF
        {
            get;
            set;
        }

        public decimal? LandGrossSF
        {
            get;
            set;
        }

        public decimal? LandGrossUnitCount
        {
            get;
            set;
        }

        public decimal? LandOverrideSizeAdj
        {
            get;
            set;
        }

        public decimal? LandSizeAdj
        {
            get;
            set;
        }

        public long? LandWidth
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        public List<RWNeighborhood> Neighborhoods
        {
            get;
            set;
        }

        public List<RWNovIncrease> NovIncreases
        {
            get;
            set;
        }

        public long? ParkingSpaces
        {
            get;
            set;
        }

        public bool PlattedFlag
        {
            get;
            set;
        }

        public decimal? TapFee
        {
            get;
            set;
        }

        public bool TifFlag
        {
            get;
            set;
        }

        public decimal TotalAcctImpInterestPct
        {
            get;
            set;
        }

        public decimal TotalAcctLandInterestPct
        {
            get;
            set;
        }

        public long? TrafficCount
        {
            get;
            set;
        }

        public bool VacantFlag
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

        public List<RWFlag> Flags
        {
            get;
            set;
        }

        public RWRealProperty()
        {
            Account = new RWAccount();
            Neighborhoods = new List<RWNeighborhood>();
            LandAbstracts = new List<RWLandAbstract>();
            LandAttributes = new List<RWLandAttribute>();
            NovIncreases = new List<RWNovIncrease>();
            Flags = new List<RWFlag>();
        }
    }
}

#endif
