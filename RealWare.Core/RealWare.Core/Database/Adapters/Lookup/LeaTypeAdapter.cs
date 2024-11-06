using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class LEATypeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpLeaType";

        public string[] IdentifierColumns => new string[] { "LEA", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public LEATypeAdapter(IDbConnection connection) : base(connection) { }

        public List<LEATypeDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<LEATypeDto>(query);
        }
    }

}
