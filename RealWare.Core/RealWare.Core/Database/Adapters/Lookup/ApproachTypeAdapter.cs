using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class ApproachTypeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpApproachType";

        public string[] IdentifierColumns => new string[] { "ApproachType", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public ApproachTypeAdapter(IDbConnection connection) : base(connection) { }

        public List<ApproachTypeDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<ApproachTypeDto>(query);
        }

        public List<ApproachTypeDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<ApproachTypeDto>(query);
        }
    }
}
