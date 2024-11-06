using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class ImpsExteriorTypeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpImpsExteriorType";

        public string[] IdentifierColumns => new string[] { "PropertyType", "ImpQuality", "ImpExterior", "TaxYear", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public ImpsExteriorTypeAdapter(IDbConnection connection) : base(connection) { }

        public List<ImpsExteriorTypeDto> GetAllActive(string taxYear = null)
        {
            Dictionary<string, object> parameters = null;
            string[] whereClause = new string[] { "ActiveFlag != 0" };

            if (taxYear != null)
            {
                whereClause = whereClause.Concat(new string[] { "TaxYear = @TaxYear" }).ToArray();
                parameters = new Dictionary<string, object> {{ "@TaxYear", taxYear }};
            }

            var query = GetDefaultSelectQueryText(this, 
                selectColumns: null, 
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<ImpsExteriorTypeDto>(query, parameters);
        }
    }
}
