using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWDetailTypes : RWBase
    {
        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string FinanceMethodAltDescription
        {
            get;
            set;
        }

        [StringLength(3, ErrorMessage = "Value cannot be longer than 3 characters.")]
        public string FinanceMethodCode
        {
            get;
            set;
        }

        [StringLength(3, ErrorMessage = "Value cannot be longer than 3 characters.")]
        public string IntendedUseCode
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string IntendedUseDescription
        {
            get;
            set;
        }

        public bool MHAffixedFlag
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string SalesAffDeedAltDescription
        {
            get;
            set;
        }

        [Required]
        [StringLength(3, ErrorMessage = "Value cannot be longer than 3 characters.")]
        public string SalesAffDeedCode
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string SalesAffPropAltDescription1
        {
            get;
            set;
        }

        [StringLength(40, ErrorMessage = "Value cannot be longer than 40 characters.")]
        public string SalesAffPropAltDescription2
        {
            get;
            set;
        }

        [StringLength(3, ErrorMessage = "Value cannot be longer than 3 characters.")]
        public string SalesAffPropertyCode1
        {
            get;
            set;
        }

        [StringLength(3, ErrorMessage = "Value cannot be longer than 3 characters.")]
        public string SalesAffPropertyCode2
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string SolarDescription
        {
            get;
            set;
        }

        public bool SolarFlag
        {
            get;
            set;
        }

        public RWDetailTypes()
        {
        }
    }
}
