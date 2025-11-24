using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models;
using RealWare.Core.Database.Models.Encompass.Table;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Table
{
    public class SaleAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TblSale";

        public string[] IdentifierColumns => new[] { "SeqId" };

        public string[] SortColums => new[] { "SaleDate", "ReceptionNo" };

        public SaleAdapter(IDbConnection connection) : base(connection) { }

        public List<SaleDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<SaleDto>(query);
        }

        public List<KeyResultDto> GetAllUniqueKeysByTaxYear(decimal taxYear)
            => GetAllUniqueKeysByTaxYear(taxYear.ToString());
        public List<KeyResultDto> GetAllUniqueKeysByTaxYear(string taxYear)
        {
            var selectClause = new string[] { "ReceptionNo AS KeyValue", "'RECEPTIONNO' AS KeyType" };
            var whereClause = new string[] { "@Version between VERSTART and VEREND" };
            var parameters = new Dictionary<string, object> { { "@Version", $"{taxYear}1231999" } };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: selectClause,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<KeyResultDto>(query, parameters);
        }
    }
}
