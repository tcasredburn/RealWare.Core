using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class DeedTypeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpDeedType";

        public string[] IdentifierColumns => new string[] { "DeedCode", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public DeedTypeAdapter(IDbConnection connection) : base(connection) { }

        public List<DeedTypeDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<DeedTypeDto>(query);
        }
    }
}
