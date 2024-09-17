#if !v5

using RealWare.Core.API.Models.Base;
using System;

namespace RealWare.Core.API.Models
{
    public class RWNoteCategory : RWBase
    {
        public DateTime RowTime { get; set; }
        public string NoteCategory { get; set; }
        public int SortOrder { get; set; }
        public int ActiveFlag { get; set; }
        public int JurisdictionId { get; set; }
        public DateTime LastUpdated { get; set; }
        public string EntityState { get; set; }
    }
}


#endif