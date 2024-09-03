using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWNovIncrease : RWBase
    {
        public DateTime LastUpdated
        {
            get;
            set;
        }

        [Required]
        public long NovIncreaseNo
        {
            get;
            set;
        }

        [Required]
        public int TaxYear
        {
            get;
            set;
        }

        public RWNovIncrease()
        {
        }
    }
}
