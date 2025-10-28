using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.TableN;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.TableN
{
    public class AdminAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TbnAdmin";

        public string[] IdentifierColumns => new string[] { "AdminNo", "JurisdictionId" };

        public string[] SortColums => new string[] { "TaxYear","AdminNo" };

        public AdminAdapter(IDbConnection connection) : base(connection) { }

        public List<AdminDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<AdminDto>(query, null);
        }

        public List<AdminDto> GetAllByTaxYear(decimal taxYear, decimal? jurisdictionId = null)
        {
            var where = new List<string> { "TaxYear = @TaxYear" };
            var parameters = new Dictionary<string, object> { { "@TaxYear", taxYear } };

            if (jurisdictionId.HasValue)
            {
                where.Add("JurisdictionId = @JurisdictionId");
                parameters.Add("@JurisdictionId", jurisdictionId.Value);
            }

            var query = GetDefaultSelectQueryText(
                this,
                selectColumns: null,
                isDistinct: true,
                whereClause: where.ToArray(),
                orderBy: SortColums);

            return ExecuteQuery<AdminDto>(query, parameters);
        }

        public AdminDto GetAllByAdminNo(decimal adminNo, decimal? jurisdictionId = null)
        {
            var where = new List<string> { "AdminNo = @AdminNo" };
            var parameters = new Dictionary<string, object> { { "@AdminNo", adminNo } };

            if (jurisdictionId.HasValue)
            {
                where.Add("JurisdictionId = @JurisdictionId");
                parameters.Add("@JurisdictionId", jurisdictionId.Value);
            }

            var query = GetDefaultSelectQueryText(
                this,
                selectColumns: null,
                isDistinct: true,
                whereClause: where.ToArray(),
                orderBy: SortColums);

            return ExecuteQuery<AdminDto>(query, parameters)?.FirstOrDefault();
        }
    }
}
