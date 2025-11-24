using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models;
using RealWare.Core.Database.Models.Encompass.Table;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Table
{
    public class PermitAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TblPermit";

        // PK per schema
        public string[] IdentifierColumns => new[] { "SeqId" };

        public string[] SortColums => new[] { "PermitDate", "PermitNo" };

        public PermitAdapter(IDbConnection connection) : base(connection) { }

        public List<PermitDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<PermitDto>(query);
        }

        public List<KeyResultDto> GetAllUniqueKeysByTaxYear(decimal taxYear, bool? isActive = null)
            => GetAllUniqueKeysByTaxYear(taxYear.ToString(), isActive);
        public List<KeyResultDto> GetAllUniqueKeysByTaxYear(string taxYear, bool? isActive = null)
        {
            var selectClause = new string[] { "PermitNo AS KeyValue", "'PERMITNO' AS KeyType" };
            var whereClause = new string[] { "@Version between VERSTART and VEREND" };
            var parameters = new Dictionary<string, object> { { "@Version", $"{taxYear}1231999" } };

            if (isActive.HasValue)
            {
                whereClause = whereClause.Concat(new string[] { "PermitActiveFlag = @PermitActiveFlag" }).ToArray();
                parameters.Add("@PermitActiveFlag", isActive.Value ? "1" : "0");
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: selectClause,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: new string[] { "KeyValue" });

            return ExecuteQuery<KeyResultDto>(query, parameters);
        }
    }
}
