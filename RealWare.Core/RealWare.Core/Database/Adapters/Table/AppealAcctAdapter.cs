using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Table;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Table
{
    public class AppealAcctAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TblAppealAcct";

        public string[] IdentifierColumns => new string[] { "SeqId" };

        public string[] SortColums => new string[] { "WriteDate" };

        public AppealAcctAdapter(IDbConnection connection) : base(connection) { }

        public List<AppealAcctDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<AppealAcctDto>(query);
        }

        public List<AppealAcctDto> GetAllByAppealNo(decimal appealNo, string taxYear = null)
        {
            var whereClause = new string[] { "AppealNo = @AppealNo" };
            var parameters = new Dictionary<string, object> { { "@AppealNo", appealNo } };

            if (taxYear != null)
            {
                whereClause = whereClause.Concat(new string[] { "@Version between VERSTART and VEREND" }).ToArray();
                parameters.Add("@Version", $"{taxYear}1231999");
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<AppealAcctDto>(query, parameters);
        }

        public List<AppealAcctDto> GetAllByAccountNo(string accountNo, string taxYear = null)
        {
            var whereClause = new string[] { "AccountNo = @AccountNo" };
            var parameters = new Dictionary<string, object>{ { "@AccountNo", accountNo } };

            if (taxYear != null)
            {
                whereClause = whereClause.Concat(new string[] { "@Version between VERSTART and VEREND" }).ToArray();
                parameters.Add("@Version", $"{taxYear}1231999");
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<AppealAcctDto>(query, parameters);
        }

        public AppealAcctDto GetBySeqId(decimal sequenceId)
        {
            var whereClause = new string[] { "SeqId = @SeqId" };
            var parameters = new Dictionary<string, object> { { "@SeqId", sequenceId } };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: null);

            return ExecuteQuery<AppealAcctDto>(query, parameters)?.FirstOrDefault();
        }
    }
}
