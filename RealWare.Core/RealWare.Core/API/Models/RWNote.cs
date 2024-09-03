using System;
using System.ComponentModel.DataAnnotations;
using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWNote : RWBase
    {
        public long? CciApplicationID
        {
            get;
            set;
        }

        public long? DetailID
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string KeyField
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string KeyValue
        {
            get;
            set;
        }

        public DateTime? LastUpdated
        {
            get;
            set;
        }

        [StringLength(20, ErrorMessage = "Value cannot be longer than 20 characters.")]
        public string NoteCategory
        {
            get;
            set;
        }

        public DateTime? NoteDate
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string NoteInitials
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public DateTime? NoteOD0
        {
            get;
            set;
        }

        public DateTime? NoteOD1
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string NoteOM0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string NoteOM1
        {
            get;
            set;
        }

        public decimal? NoteON0
        {
            get;
            set;
        }

        public decimal? NoteON1
        {
            get;
            set;
        }

        public decimal? NoteON2
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string NoteOT0
        {
            get;
            set;
        }

        [StringLength(50, ErrorMessage = "Value cannot be longer than 50 characters.")]
        public string NoteOT1
        {
            get;
            set;
        }

        [StringLength(4000, ErrorMessage = "Value cannot be longer than 4000 characters.")]
        public string NoteText
        {
            get;
            set;
        }

        public bool? ShowAssessorFlag
        {
            get;
            set;
        }

        public bool? ShowCollectorFlag
        {
            get;
            set;
        }

        public bool? ShowPublicFlag
        {
            get;
            set;
        }

        public bool? ShowRecorderFlag
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string SubKeyField
        {
            get;
            set;
        }

        [StringLength(30, ErrorMessage = "Value cannot be longer than 30 characters.")]
        public string SubKeyValue
        {
            get;
            set;
        }

        public RWNote()
        {
            CciApplicationID = Constants.DEFAULT_REALWARE_APPLICATION_ID;
            ShowCollectorFlag = false;
        }
    }
}
