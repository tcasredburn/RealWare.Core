using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWApplicationAccount : RWBase
    {
        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        public string AccountNo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the primary account.
        /// </summary>
        public bool PrimaryAccount { get; set; }

        /// <summary>
        /// Default constructor for an application account.
        /// </summary>
        public RWApplicationAccount()
        {
        }
    }
}
