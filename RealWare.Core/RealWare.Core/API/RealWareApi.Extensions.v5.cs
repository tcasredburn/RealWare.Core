#if v5

using RealWare.Core.API.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RealWare.Core.API
{
    public partial class RealWareApi
    {
        /// <summary>
        /// Synchronous version of InsertAccountNoteAsync.
        /// </summary>
        public void InsertAccountNote(string accountNo, string taxYear, string category, string note,
             DateTime? noteDate = null, bool showPublic = false, bool showAssessor = true, string noteInitials = null)
            => InsertAccountNoteAsync(accountNo, taxYear, category, note, noteDate, showPublic, showAssessor, noteInitials).GetAwaiter().GetResult();
        /// <summary>
        /// This will insert a note into the specified account.
        /// Note: Due to the limitations of the v5 API, this function will update the notes via the RealAccount endpoint.
        /// </summary>
        public async Task InsertAccountNoteAsync(string accountNo, string taxYear, string category, string note,
             DateTime? noteDate = null, bool showPublic = false, bool showAssessor = true, string noteInitials = null, 
             CancellationToken cancellationToken = default)
        {
            var accountDto = await GetRealAccountAsync(accountNo, taxYear, cancellationToken).ConfigureAwait(false);

            if (accountDto == null)
                throw new NullReferenceException("Error retreiving account from api.");

            var newNote = getRWNote(Constants.REALWARE_KEYFIELD_ACCOUNTNO, accountNo, category, 
                note, noteDate, showPublic, showAssessor, noteInitials);

            accountDto.Account.Notes.Add(newNote);

            await UpdateRealAccountAsync(accountDto, taxYear, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronous version of InsertSaleNoteAsync.
        /// </summary>
        public void InsertSaleNote(string receptionNo, string category, string note,
        DateTime? noteDate = null, bool showPublic = false, bool showAssessor = true, string noteInitials = null)
            => InsertSaleNoteAsync(receptionNo, category, note, noteDate, showPublic, showAssessor, noteInitials).GetAwaiter().GetResult();
        /// <summary>
        /// This will insert a note into the specified sale.
        /// Note: Due to the limitations of the v5 API, this function will update the notes via the Sale endpoint.
        /// </summary>
        public async Task InsertSaleNoteAsync(string receptionNo, string category, string note,
             DateTime? noteDate = null, bool showPublic = false, bool showAssessor = true, string noteInitials = null,
             CancellationToken cancellationToken = default)
        {
            var saleDto = await GetSaleAsync(receptionNo, cancellationToken).ConfigureAwait(false);

            if (saleDto == null)
                throw new NullReferenceException("Error retreiving sale from api.");

            var newNote = getRWNote(Constants.REALWARE_KEYFIELD_RECEPTIONNO, receptionNo, category,
                note, noteDate, showPublic, showAssessor, noteInitials);

            saleDto.Notes.Add(newNote);

            await UpdateSaleAsync(saleDto, receptionNo, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronous version of InsertPermitNoteAsync.
        /// </summary>
        public void InsertPermitNote(string permitNo, string taxYear, string category, string note,
        DateTime? noteDate = null, bool showPublic = false, bool showAssessor = true, string noteInitials = null)
            => InsertPermitNoteAsync(permitNo, taxYear, category, note, noteDate, showPublic, showAssessor, noteInitials).GetAwaiter().GetResult();
        /// <summary>
        /// This will insert a note into the specified permit.
        /// Note: Due to the limitations of the v5 API, this function will update the notes via the Permit endpoint.
        /// </summary>
        public async Task InsertPermitNoteAsync(string permitNo, string taxYear, string category, string note,
             DateTime? noteDate = null, bool showPublic = false, bool showAssessor = true, string noteInitials = null,
             CancellationToken cancellationToken = default)
        {
            var permitDto = await GetPermitAsync(permitNo, taxYear, cancellationToken).ConfigureAwait(false);

            if (permitDto == null)
                throw new NullReferenceException("Error retreiving permit from api.");

            var newNote = getRWNote(Constants.REALWARE_KEYFIELD_PERMITNO, permitNo, category,
                note, noteDate, showPublic, showAssessor, noteInitials);

            permitDto.Notes.Add(newNote);

            await UpdatePermitAsync(permitDto, permitNo, taxYear, cancellationToken).ConfigureAwait(false);
        }

        private RWNote getRWNote(string keyField, string accountNo, string category, string note,
             DateTime? noteDate = null, bool showPublic = false, bool showAssessor = true, string noteInitials = null)
        {
            return new RWNote
            {
                ShowAssessorFlag = showAssessor,
                DetailID = null,
                KeyField = Constants.REALWARE_KEYFIELD_ACCOUNTNO,
                KeyValue = accountNo,
                LastUpdated = DateTime.Now,
                NoteCategory = category,
                NoteDate = noteDate ?? DateTime.Now,
                NoteInitials = noteInitials,
                ShowPublicFlag = showPublic,
                SubKeyValue = keyField,
                SubKeyField = keyField == Constants.REALWARE_KEYFIELD_ACCOUNTNO 
                    ? Constants.REALWARE_KEYFIELD_IMPROVEMENTNO 
                    : null,
                ShowRecorderFlag = false,
                NoteText = note
            };
        }
    }
}
#endif