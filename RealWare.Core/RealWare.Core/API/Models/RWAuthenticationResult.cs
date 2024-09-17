using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWAuthenticationResult : RWBase
    {
        public string AccessToken
        {
            get;
            set;
        }

        public bool Authenticated
        {
            get;
            set;
        }

        public string TokenType
        {
            get;
            set;
        }

        public RWAuthenticationResult()
        {
        }
    }
}
