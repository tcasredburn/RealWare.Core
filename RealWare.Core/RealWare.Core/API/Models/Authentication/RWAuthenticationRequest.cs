using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models.Authentication
{
    public class RWAuthenticationRequest : RWBase
    {
        public string GrantType
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }

        public RWAuthenticationRequest()
        {
            GrantType = "password"; // Default type
        }
    }
}
