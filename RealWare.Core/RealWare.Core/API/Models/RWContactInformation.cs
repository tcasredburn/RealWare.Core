using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWContactInformation : RWBase
    {
        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string BuyerAddress
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string BuyerCity
        {
            get;
            set;
        }

        [StringLength(80, ErrorMessage = "Value cannot be longer than 80 characters.")]
        public string BuyerName
        {
            get;
            set;
        }

        [StringLength(18, ErrorMessage = "Value cannot be longer than 18 characters.")]
        public string BuyerPhone
        {
            get;
            set;
        }

        public bool BuyerSignatureFlag
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string BuyerState
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string BuyerZipcode
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string CompletedByAddress
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string CompletedByCity
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string CompletedByName
        {
            get;
            set;
        }

        [StringLength(18, ErrorMessage = "Value cannot be longer than 18 characters.")]
        public string CompletedByPhone
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string CompletedByState
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string CompletedByZipcode
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string MailToAddress
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string MailToCity
        {
            get;
            set;
        }

        [StringLength(80, ErrorMessage = "Value cannot be longer than 80 characters.")]
        public string MailToName
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string MailToState
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string MailToZipcode
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string SellerAddress
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string SellerCity
        {
            get;
            set;
        }

        [StringLength(80, ErrorMessage = "Value cannot be longer than 80 characters.")]
        public string SellerName
        {
            get;
            set;
        }

        [StringLength(18, ErrorMessage = "Value cannot be longer than 18 characters.")]
        public string SellerPhone
        {
            get;
            set;
        }

        public bool SellerSignatureFlag
        {
            get;
            set;
        }

        [StringLength(2, ErrorMessage = "Value cannot be longer than 2 characters.")]
        public string SellerState
        {
            get;
            set;
        }

        [StringLength(10, ErrorMessage = "Value cannot be longer than 10 characters.")]
        public string SellerZipcode
        {
            get;
            set;
        }

        public RWContactInformation()
        {
        }
    }
}
