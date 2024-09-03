using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWListBuilderQueryParameter : RWBase
    {
        [Required]
        public string ParameterName
        {
            get;
            set;
        }

        [Required]
        public string Value
        {
            get;
            set;
        }

        public RWListBuilderQueryParameter()
        {
        }
    }
}
