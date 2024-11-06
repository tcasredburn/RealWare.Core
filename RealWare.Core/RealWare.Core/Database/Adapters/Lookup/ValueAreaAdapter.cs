using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class ValueAreaAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpValueArea";

        public string[] IdentifierColumns => new string[] { "ValueAreaCode", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public ValueAreaAdapter(IDbConnection connection) : base(connection) { }

        public List<ValueAreaDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<ValueAreaDto>(query);
        }
    }

}
