using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Sale
{
    public class RWSaleInventory : RWBase
    {
        public decimal AcctAdjSaleprice
        {
            get;
            set;
        }

        public decimal AcctAdjSaleValuePer
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string AcctType
        {
            get;
            set;
        }

        public decimal AdjSaleprice
        {
            get;
            set;
        }

        public int? AdjustedYearBuilt
        {
            get;
            set;
        }

        public decimal? AgLandValue
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string ApproachType
        {
            get;
            set;
        }

        public decimal? BathCount
        {
            get;
            set;
        }

        public decimal? BedroomCount
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string Block
        {
            get;
            set;
        }

        public long? BltAsCode
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string BltAsDescription
        {
            get;
            set;
        }

        public long? BltAsStoryHeight
        {
            get;
            set;
        }

        public long? BltAsTotalUnitCount
        {
            get;
            set;
        }

        public int? BltAsYearBuilt
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

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ClassCode
        {
            get;
            set;
        }

        public decimal? CommercialSF
        {
            get;
            set;
        }

        public decimal CondoImpPercent
        {
            get;
            set;
        }

        public long? CondoImpSF
        {
            get;
            set;
        }

        public bool ConfirmedFlag
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string DeedCode
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string EconomicAreaCode
        {
            get;
            set;
        }

        public int? EffectiveAge
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

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string FilingNo
        {
            get;
            set;
        }

        public decimal? FinalSF
        {
            get;
            set;
        }

        public decimal FinalSFValuePer
        {
            get;
            set;
        }

        public long? FixtureCount
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string FloorCover
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GranteeAddress1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GranteeAddress2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GranteeCity
        {
            get;
            set;
        }

        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string GranteeCountry
        {
            get;
            set;
        }

        [StringLength(80, ErrorMessage = "Value cannot be longer than 80 characters.")]
        public string GranteeName1
        {
            get;
            set;
        }

        [StringLength(60, ErrorMessage = "Value cannot be longer than 60 characters.")]
        public string GranteeName2
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string GranteePostalCode
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GranteeProvince
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string GranteeStateCode
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string GranteeZipcode
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GrantorAddress1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GrantorAddress2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GrantorCity
        {
            get;
            set;
        }

        [StringLength(100, ErrorMessage = "Value cannot be longer than 100 characters.")]
        public string GrantorCountry
        {
            get;
            set;
        }

        [StringLength(80, ErrorMessage = "Value cannot be longer than 80 characters.")]
        public string GrantorName1
        {
            get;
            set;
        }

        [StringLength(60, ErrorMessage = "Value cannot be longer than 60 characters.")]
        public string GrantorName2
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string GrantorPostalCode
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string GrantorProvince
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string GrantorStateCode
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string GrantorZipcode
        {
            get;
            set;
        }

        public bool GroupInventoryFlag
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string HvacType
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string ImpAbstractCode
        {
            get;
            set;
        }

        public long? ImpBltAsOther
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string ImpConditionType
        {
            get;
            set;
        }

        public long? ImpCount
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string ImpExterior
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ImpInterior
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string ImpQuality
        {
            get;
            set;
        }

        public bool ImprovedFlag
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string ImpUnitType
        {
            get;
            set;
        }

        public List<RWSaleInventoryDetail> InventoryDetails
        {
            get;
            set;
        }

        public DateTime? InventoryEffectiveDate
        {
            get;
            set;
        }

        public bool InventoryOverrideFlag
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string LandAbstractCode
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

        public decimal? LandExcessSF
        {
            get;
            set;
        }

        public decimal? LandGrossAcreCount
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

        public decimal? LandNetAcreCount
        {
            get;
            set;
        }

        public decimal? LandNetFF
        {
            get;
            set;
        }

        public decimal? LandNetSF
        {
            get;
            set;
        }

        public decimal? LandNetUnitCount
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string LandType
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string LEA
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

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string Lot
        {
            get;
            set;
        }

        public decimal? MarketLandValue
        {
            get;
            set;
        }

        public bool MultipleUseFlag
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdCode1
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdCode2
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdCode3
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdCode4
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdExtension1
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdExtension2
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdExtension3
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string NbhdExtension4
        {
            get;
            set;
        }

        public long? OccCode1
        {
            get;
            set;
        }

        public long? OccCode2
        {
            get;
            set;
        }

        public long? OccCode3
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string OccCodeDescription1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string OccCodeDescription2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string OccCodeDescription3
        {
            get;
            set;
        }

        public decimal? OccCompletedPct
        {
            get;
            set;
        }

        public decimal? OutBuildingCount
        {
            get;
            set;
        }

        public decimal? OutBuildingSF
        {
            get;
            set;
        }

        public decimal? OutBuildingValue
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string OutOfAreaSaleJurisdiction
        {
            get;
            set;
        }

        public string ParcelNo
        {
            get;
            set;
        }

        public int? PhysicalAge
        {
            get;
            set;
        }

        public bool PlattedFlag
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string PostDirection
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string PreDirection
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

        public decimal PriorYearTaxrollActualAmt
        {
            get;
            set;
        }

        public decimal PriorYearTaxrollAssessed
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PropertyCity
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string PropertyType
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string PropertyZipcode
        {
            get;
            set;
        }

        public decimal? ResidentialSF
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string RoofCover
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string RoofType
        {
            get;
            set;
        }

        public int? RoomCount
        {
            get;
            set;
        }

        public DateTime? SaleDate
        {
            get;
            set;
        }

        public DateTime? SaleInventoryOD0
        {
            get;
            set;
        }

        public DateTime? SaleInventoryOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleInventoryOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleInventoryOM1
        {
            get;
            set;
        }

        public decimal? SaleInventoryON0
        {
            get;
            set;
        }

        public decimal? SaleInventoryON1
        {
            get;
            set;
        }

        public decimal? SaleInventoryON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleInventoryOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string SaleInventoryOT1
        {
            get;
            set;
        }

        public decimal SalePrice
        {
            get;
            set;
        }

        public decimal? SaleRatio
        {
            get;
            set;
        }

        public decimal SaleValuePer
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string StreetName
        {
            get;
            set;
        }

        [StringLength(15, ErrorMessage = "Value cannot be longer than 15 characters.")]
        public string StreetNo
        {
            get;
            set;
        }

        [StringLength(4, ErrorMessage = "Value cannot be longer than 4 characters.")]
        public string StreetType
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string Subdivision
        {
            get;
            set;
        }

        [StringLength(255, ErrorMessage = "Value cannot be longer than 255 characters.")]
        public string SubdivisionName
        {
            get;
            set;
        }

        public decimal TimeAdjSaleprice
        {
            get;
            set;
        }

        public decimal TotalAcctValueTimeofSale
        {
            get;
            set;
        }

        public decimal? TotalFinishedSF
        {
            get;
            set;
        }

        public decimal? TotalImpSF
        {
            get;
            set;
        }

        public decimal TotalLandValueTimeofSale
        {
            get;
            set;
        }

        public decimal? TotalUnfinishedSF
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string Tract
        {
            get;
            set;
        }

        [StringLength(6, ErrorMessage = "Value cannot be longer than 6 characters.")]
        public string UnitName
        {
            get;
            set;
        }

        public bool Valid1Flag
        {
            get;
            set;
        }

        public bool Valid2Flag
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

        public decimal? ZonedArea
        {
            get;
            set;
        }

        public decimal ZonedAreaValuePer
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

        public RWSaleInventory()
        {
            InventoryDetails = new List<RWSaleInventoryDetail>();
        }
    }
}
