using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class ImpsQualityAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpImpsQuality";

        public string[] IdentifierColumns => new string[] { "ImpQuality", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public ImpsQualityAdapter(IDbConnection connection) : base(connection) { }

        public List<ImpsQualityDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<ImpsQualityDto>(query);
        }
    }
}
