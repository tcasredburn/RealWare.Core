using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class SaleConfirmMethodAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpSaleConfirmMethod";

        public string[] IdentifierColumns => new string[] { "ConfirmMethod", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public SaleConfirmMethodAdapter(IDbConnection connection) : base(connection) { }

        public List<SaleConfirmMethodDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<SaleConfirmMethodDto>(query);
        }
    }
}
