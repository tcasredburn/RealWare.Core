using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class ImpsRoofTypeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpImpsRoofType";

        public string[] IdentifierColumns => new string[] { "RoofType", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public ImpsRoofTypeAdapter(IDbConnection connection) : base(connection) { }

        public List<ImpsRoofTypeDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<ImpsRoofTypeDto>(query);
        }
    }
}
