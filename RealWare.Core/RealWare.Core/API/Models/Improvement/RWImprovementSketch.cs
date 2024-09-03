using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Improvement
{
    internal class RWImprovementSketch : RWBase
    {
        [Required]
        public string AccountNo
        {
            get;
            set;
        }

        public long? DetailID
        {
            get;
            set;
        }

        [Required]
        public decimal ImpNo
        {
            get;
            set;
        }

        [Required]
        public byte[] SketchObject
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

        public RWImprovementSketch()
        {
        }
    }
}
