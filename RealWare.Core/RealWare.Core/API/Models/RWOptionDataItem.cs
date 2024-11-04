using System.Collections.Generic;

namespace RealWare.Core.API.Models
{
    public class RWOptionDataItem
    {
        public string OptionItemKey { get; set; }
        public List<RWKeyValuePair<string, string>> DisplayColumns { get; set; }
        public List<RWKeyValuePair<string, string>> AdditionalColumns { get; set; }
        public long Order { get; set; }

        public RWOptionDataItem()
        {
            DisplayColumns = new List<RWKeyValuePair<string, string>>();
            AdditionalColumns = new List<RWKeyValuePair<string, string>>();
        }
    }
}
