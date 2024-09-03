using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWPingResponse : RWBase
    {
        public string DeployedOn
        {
            get;
            set;
        }
        public string ServerTime
        {
            get;
            set;
        }

        public RWPingResponse()
        {

        }
    }
}
