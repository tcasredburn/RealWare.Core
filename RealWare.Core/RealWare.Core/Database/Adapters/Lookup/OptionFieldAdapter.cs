using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class OptionFieldAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpOptionField";

        public string[] IdentifierColumns => new string[] { "FieldName", "FieldValue", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public OptionFieldAdapter(IDbConnection connection) : base(connection) { }

        public List<OptionFieldDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<OptionFieldDto>(query);
        }

        public List<OptionFieldDto> GetAllByFieldName(string fieldName)
        {
            var whereClause = new string[] { "FieldName = @FieldName" };
            var parameters = new Dictionary<string, object> { { "@FieldName", fieldName } };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<OptionFieldDto>(query, parameters);
        }
    }
}
