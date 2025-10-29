using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class PrimaryUseCodeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpPrimaryUseCode";

        public string[] IdentifierColumns => new string[] { "PrimaryUseCode", "AppraisalType", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public PrimaryUseCodeAdapter(IDbConnection connection) : base(connection) { }

        public List<PrimaryUseCodeDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<PrimaryUseCodeDto>(query);
        }

        public List<PrimaryUseCodeDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<PrimaryUseCodeDto>(query);
        }
    }
}
