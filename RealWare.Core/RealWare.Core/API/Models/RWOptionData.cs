using RealWare.Core.API.Models.Base;
using System.Collections.Generic;

namespace RealWare.Core.API.Models
{
    public class RWOptionData : RWBase
    {
        public string Key { get; set; }
        public string FieldName { get; set; }
        public List<RWOptionDataItem> OptionItems { get; set; }

        public RWOptionData()
        {
            OptionItems = new List<RWOptionDataItem>();
        }
    }
}
