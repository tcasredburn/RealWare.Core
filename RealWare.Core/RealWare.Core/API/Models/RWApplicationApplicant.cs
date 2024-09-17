using RealWare.Core.API.Models.Base;
using System.Collections.Generic;

namespace RealWare.Core.API.Models
{
    public class RWApplicationApplicant : RWBase
    {
        /// <summary>
        /// Gets or sets the person code.
        /// </summary>
        public int? PersonCode { get; set; }

        /// <summary>
        /// Gets or sets the address code.
        /// </summary>
        public int? AddressCode { get; set; }

        /// <summary>
        /// Gets or sets the applicant type code.
        /// </summary>
        public string ApplicantTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the application applicant ID.
        /// </summary>
        public int ApplicationApplicantID { get; set; }

        /// <summary>
        /// Gets or sets the list of applications.
        /// </summary>
        public List<RWApplication> Applications { get; set; }

        /// <summary>
        /// Default constructor for an application applicant.
        /// </summary>
        public RWApplicationApplicant()
        {
            Applications = new List<RWApplication>();
        }
    }
}
