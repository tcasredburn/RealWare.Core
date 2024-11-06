using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class ImpsConditionTypeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpImpsConditionType";

        public string[] IdentifierColumns => new string[] { "ImpConditionType", "TaxYear", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public ImpsConditionTypeAdapter(IDbConnection connection) : base(connection) { }

        public List<ImpsConditionTypeDto> GetAllActive(string taxYear = null)
        {
            Dictionary<string, object> parameters = null;
            string[] whereClause = new string[] { "ActiveFlag != 0" };

            if (taxYear != null)
            {
                whereClause = whereClause.Concat(new string[] { "TaxYear = @TaxYear" }).ToArray();
                parameters = new Dictionary<string, object> { { "@TaxYear", taxYear } };
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<ImpsConditionTypeDto>(query, parameters);
        }
    }
}
