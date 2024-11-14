using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Table;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Table
{
    public class AcctPropertyAddressAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TblAcctPropertyAddress";

        public string[] IdentifierColumns => new string[] { "SeqId" };

        public string[] SortColums => new string[] { "OrderNo" };

        public AcctPropertyAddressAdapter(IDbConnection connection) : base(connection) { }

        public List<AcctPropertyAddressDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<AcctPropertyAddressDto>(query);
        }

        public List<AcctPropertyAddressDto> GetAllByAccountNo(string accountNo, string taxYear = null)
        {
            var whereClause = new string[] { "AccountNo = @AccountNo" };
            var parameters = new Dictionary<string, object> { { "@AccountNo", accountNo } };

            if (taxYear != null)
            {
                whereClause = whereClause.Concat(new string[] { "@Version between VERSTART and VEREND" }).ToArray();
                parameters.Add("@Version", $"{taxYear}1231999");
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<AcctPropertyAddressDto>(query, parameters);
        }

        public AcctPropertyAddressDto GetByAccountNo(string accountNo, string taxYear = null, int orderNo = 1)
        {
            var whereClause = new string[] { "AccountNo = @AccountNo", "OrderNo = @OrderNo" };
            var parameters = new Dictionary<string, object>
            {
                { "@AccountNo", accountNo },
                { "@OrderNo", orderNo }
            };

            if (taxYear != null)
            {
                whereClause = whereClause.Concat(new string[] { "@Version between VERSTART and VEREND" }).ToArray();
                parameters.Add("@Version", $"{taxYear}1231999");
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<AcctPropertyAddressDto>(query, parameters).FirstOrDefault();
        }
    }
}
