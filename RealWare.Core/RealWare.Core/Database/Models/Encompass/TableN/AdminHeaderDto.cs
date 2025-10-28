using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.TableN
{
    public class AdminHeaderDto : RealWareDtoBase
    {
        public string AccountNo { get; set; }
        public decimal? GroupAccountFlag { get; set; }
        public decimal AdminNo { get; set; }
        public string ParcelNo { get; set; }
        public string SubNo { get; set; }
        public string FilingNo { get; set; }
        public string Block { get; set; }
        public string Tract { get; set; }
        public string AreaId { get; set; }
        public string MailingCode { get; set; }
        public string AcctType { get; set; }
        public string StateSalesTaxId { get; set; }
        public string ValueAreaCode { get; set; }
        public string LocalNo { get; set; }
        public string SubName { get; set; }
        public DateTime? HeaderTimeStamp { get; set; }
        public decimal? NoticeNo { get; set; }
        public DateTime NoticeDate { get; set; }
        public decimal JurisdictionId { get; set; }
        public string Legal { get; set; }
        public string BusinessTypeDescription { get; set; }
        public string BusinessCode { get; set; }
        public string FederalId { get; set; }
        public string BusinessLicense { get; set; }
        public string Ward { get; set; }
        public string PPCityCode { get; set; }
        public string AssociatedAcct { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string PrimaryUseCode { get; set; }
        public string AcctStatusCode { get; set; }
        public string AppraisalType { get; set; }
        public decimal? PropertyClassId { get; set; }
        public string DefaultTaxDistrict { get; set; }
        public string DefaultLtea { get; set; }
        public string SACalculationType { get; set; }
        public string ShortDescription { get; set; }
        public string MobileHomeSpace { get; set; }
        public decimal? OGArchiveId { get; set; }
        public decimal? PPArchiveId { get; set; }
        public decimal? RealArchiveId { get; set; }
        public decimal? PriorAdminNo { get; set; }
        public DateTime? PPDeclarationSentDate { get; set; }
        public string GroupAccountCode { get; set; }
        public decimal? PrimaryGroupAccountFlag { get; set; }
        public decimal? MovingPermitNo { get; set; }

        /// <summary>
        /// Returns true if GroupAccountFlag is not 0
        /// </summary>
        public bool IsGroupAccount => (GroupAccountFlag ?? 0) != 0;

        /// <summary>
        /// Returns true if PrimaryGroupAccountFlag is not 0
        /// </summary>
        public bool IsPrimaryGroupAccount => (PrimaryGroupAccountFlag ?? 0) != 0;
    }
}
