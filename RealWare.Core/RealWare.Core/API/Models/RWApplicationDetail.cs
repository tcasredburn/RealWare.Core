using RealWare.Core.API.Models.Base;
using System;

namespace RealWare.Core.API.Models
{
    public class RWApplicationDetail : RWBase
    {
        /// <summary>
        /// Gets or sets the application definition ID.
        /// </summary>
        public long ApplicationDefinitionID { get; set; }

        /// <summary>
        /// Gets or sets the application detail number.
        /// </summary>
        public decimal? ApplicationDetailNumber { get; set; }

        /// <summary>
        /// Gets or sets the application detail date.
        /// </summary>
        public DateTime? ApplicationDetailDate { get; set; }

        /// <summary>
        /// Gets or sets the application detail text.
        /// </summary>
        public string ApplicationDetailText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the application definition index is set.
        /// </summary>
        public bool? ApplicationDefinitionIndex { get; set; }

        /// <summary>
        /// Gets or sets the write date.
        /// </summary>
        public DateTime? WriteDate { get; set; }

        /// <summary>
        /// Default constructor for an application detail row.
        /// </summary>
        public RWApplicationDetail()
        {
        }
    }
}
