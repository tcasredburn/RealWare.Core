using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class ImpsOccTypeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpImpsOccType";

        public string[] IdentifierColumns => new string[] { "OccCode", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public ImpsOccTypeAdapter(IDbConnection connection) : base(connection) { }

        public List<ImpsOccTypeDto> GetAllActive()
        {
            Dictionary<string, object> parameters = null;
            string[] whereClause = new string[] { "ActiveFlag != 0" };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<ImpsOccTypeDto>(query, parameters);
        }
    }
}
