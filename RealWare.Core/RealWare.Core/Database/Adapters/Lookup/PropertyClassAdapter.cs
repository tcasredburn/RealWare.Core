using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class PropertyClassAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpPropertyClass";

        public string[] IdentifierColumns => new string[] { "PropertyClassId", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public PropertyClassAdapter(IDbConnection connection) : base(connection) { }

        public List<PropertyClassDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<PropertyClassDto>(query);
        }

        public List<PropertyClassDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<PropertyClassDto>(query);
        }
    }
}
