using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class EconomicAreaAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpEconomicArea";

        public string[] IdentifierColumns => new string[] { "EconomicAreaCode", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public EconomicAreaAdapter(IDbConnection connection) : base(connection) { }

        public List<EconomicAreaDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<EconomicAreaDto>(query);
        }
    }

}
