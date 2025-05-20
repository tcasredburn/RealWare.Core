using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class DocumentTypeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpDocumentType";

        public string[] IdentifierColumns => new string[] { "DocumentCode", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public DocumentTypeAdapter(IDbConnection connection) : base(connection) { }

        public List<DocumentTypeDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<DocumentTypeDto>(query);
        }
    }
}
