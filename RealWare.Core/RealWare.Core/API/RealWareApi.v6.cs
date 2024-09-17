#if !v5

using RealWare.Core.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace RealWare.Core.API
{
    /// <summary>
    /// Additional endpoints for v6+ of the RealWare API.
    /// </summary>
    public partial class RealWareApi
    {
        /// <summary>
        /// Gets a list of notes for the specified note type, key field value, and tax year.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<List<RWNote>> GetNotesAsync(string keyFieldValue, string taxYear, RWNoteType noteType, CancellationToken cancellationToken = default)
        {
            if (keyFieldValue == null)
                throw new ArgumentNullException(nameof(keyFieldValue));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/notes/{Enum.GetName(typeof(RWNoteType), noteType)}/{taxYear}/{keyFieldValue}";
            return await ExecuteAsync<List<RWNote>>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of notes for the specified note type, key field value, and tax year.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<List<RWNote>> GetNotesAsync(string keyFieldValue, string taxYear, RWNoteType noteType, 
            string subKeyField, string subKeyFieldValue, CancellationToken cancellationToken = default)
        {
            if (keyFieldValue == null)
                throw new ArgumentNullException(nameof(keyFieldValue));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/notes/{Enum.GetName(typeof(RWNoteType), noteType)}/{taxYear}/{keyFieldValue}/{subKeyField}/{subKeyFieldValue}";
            return await ExecuteAsync<List<RWNote>>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a list of the note categories.
        /// </summary>
        public async Task<List<RWNoteCategory>> GetNoteCategoriesAsync(CancellationToken cancellationToken = default)
        {
            string url = $"api/notes/notecategories";
            return await ExecuteAsync<List<RWNoteCategory>>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Inserts a new note.
        /// </summary>
        /// <returns>True if successful.</returns>
        public async Task<bool> InsertNoteAsync(RWNote note, string keyField, string keyValue, string taxYear, CancellationToken cancellationToken = default)
        {
            if(note == null)
                throw new ArgumentNullException(nameof(note));

            if (keyField == null)
                throw new ArgumentNullException(nameof(keyField));

            if(keyValue == null)
                throw new ArgumentNullException(nameof(keyValue));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/notes/realware/{taxYear}/{keyField}/{keyValue}";
            return await ExecuteAsync<bool>(url, RWHttpVerb.POST, note, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}

#endif