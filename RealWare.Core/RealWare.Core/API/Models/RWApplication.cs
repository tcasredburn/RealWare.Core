using RealWare.Core.API.Models.Base;
using System.Collections.Generic;

namespace RealWare.Core.API.Models
{
    public class RWApplication : RWBase
    {
        /// <summary>
        /// Gets or sets the application record number.
        /// </summary>
        public string ApplicationRecordNo { get; set; }

        /// <summary>
        /// Gets or sets the application type.
        /// </summary>
        public string ApplicationType { get; set; }

        /// <summary>
        /// Gets or sets the application status.
        /// </summary>
        public string ApplicationStatus { get; set; }

        /// <summary>
        /// Gets or sets the application deny code.
        /// </summary>
        public string ApplicationDenyCode { get; set; }

        /// <summary>
        /// Gets or sets the applicant type code.
        /// </summary>
        public string ApplicantTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the renewal year.
        /// </summary>
        public int? RenewalYear { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the applicant is a resident.
        /// </summary>
        public bool? ResidencyFlag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the form is signed.
        /// </summary>
        public bool? FormSignedFlag { get; set; }

        /// <summary>
        /// Gets or sets the signer type code.
        /// </summary>
        public string SignerTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the mail date.
        /// </summary>
        public string MailDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        public string DueDate { get; set; }

        /// <summary>
        /// Gets or sets the received date.
        /// </summary>
        public string ReceivedDate { get; set; }

        /// <summary>
        /// Gets or sets the application effective year.
        /// </summary>
        public int? ApplicationEffectiveYear { get; set; }

        /// <summary>
        /// Gets or sets the write date.
        /// </summary>
        public string WriteDate { get; set; }

        /// <summary>
        /// Gets or sets the application applicant ID.
        /// </summary>
        public int? ApplicationApplicantId { get; set; }

        /// <summary>
        /// Gets or sets the application process status.
        /// </summary>
        public string ApplicationProcessStatus { get; set; }

        /// <summary>
        /// Gets or sets the list of accounts associated with the application.
        /// </summary>
        public List<RWApplicationAccount> Accounts { get; set; }

        /// <summary>
        /// Gets or sets the application details.
        /// </summary>
        public List<RWApplicationDetail> ApplicationDetails { get; set; }

        /// <summary>
        /// Default constructor for an application.
        /// </summary>
        public RWApplication()
        {
            Accounts = new List<RWApplicationAccount>();
            ApplicationDetails = new List<RWApplicationDetail>();
        }
    }
}
