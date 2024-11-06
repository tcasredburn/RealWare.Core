using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class NbhdAdjustmentAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpNbhdAdjustment";

        public string[] IdentifierColumns => new string[] { "NbhdCode", "NbhdExtension", "PropertyType", "TaxYear", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public NbhdAdjustmentAdapter(IDbConnection connection) : base(connection) { }

        public List<NbhdAdjustmentDto> GetAllActive(string taxYear = null, string propertyType = null)
        {
            Dictionary<string, object> parameters = null;
            var whereClause = new string[] { "ActiveFlag != 0" };

            if (taxYear != null)
            {
                whereClause = whereClause.Concat(new string[] { "TaxYear = @TaxYear" }).ToArray();
                parameters = new Dictionary<string, object> { { "@TaxYear", taxYear } };
            }

            if (propertyType != null)
            {
                whereClause = whereClause.Concat(new string[] { "PropertyType = @PropertyType" }).ToArray();
                if (parameters == null)
                    parameters = new Dictionary<string, object>();
                parameters.Add("@PropertyType", propertyType);
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<NbhdAdjustmentDto>(query, parameters);
        }
    }

}
