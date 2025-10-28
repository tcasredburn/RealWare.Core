using RealWare.Core.Database.Models.Encompass.Base;
using System;

namespace RealWare.Core.Database.Models.Encompass.TableN
{
    public class AdminDto : RealWareDtoBase
    {
        public decimal AdminNo { get; set; }
        public decimal StatusAdminId { get; set; }
        public string AdminName { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal CCIApplicationId { get; set; }
        public string AdminDescription { get; set; }
        public decimal JurisdictionId { get; set; }
        public decimal TaxYear { get; set; }
        public decimal? QueryId { get; set; }
        public decimal? ProcessAllOwnerAddressFlag { get; set; }
        public decimal? AdminProcessTypeId { get; set; }
        public decimal? OwnershipChangeResendFlag { get; set; }
        public decimal? ValueChangeResentFlag { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string AdminComments { get; set; }
        public decimal? ProcessedAdminNo { get; set; }
        public decimal? AdminUserId { get; set; }

        /// <summary>
        /// Returns true if the ProcessAllOwnerAddressFlag is not 0
        /// </summary>
        public bool IsProcessAllOwnerAddress => (ProcessAllOwnerAddressFlag ?? 0) != 0;

        /// <summary>
        /// Returns true if the OwnershipChangeResendFlag is not 0
        /// </summary>
        public bool IsOwnershipChangeResend => (OwnershipChangeResendFlag ?? 0) != 0;

        /// <summary>
        /// Returns true if the ValueChangeResentFlag is not 0
        /// </summary>
        public bool IsValueChangeResent => (ValueChangeResentFlag ?? 0) != 0;
    }
}
