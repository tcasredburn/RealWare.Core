using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class SaleExcludeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpSaleExclude";

        public string[] IdentifierColumns => new string[] { "ExcludeCode", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public SaleExcludeAdapter(IDbConnection connection) : base(connection) { }

        public List<SaleExcludeDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<SaleExcludeDto>(query);
        }
    }

}
