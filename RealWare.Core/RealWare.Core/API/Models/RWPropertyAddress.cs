using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWPropertyAddress : RWBase
    {
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

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string PropertyCity
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

        [StringLength(6, ErrorMessage = "Value cannot be longer than 6 characters.")]
        public string UnitName
        {
            get;
            set;
        }

        public RWPropertyAddress()
        {
        }
    }
}
