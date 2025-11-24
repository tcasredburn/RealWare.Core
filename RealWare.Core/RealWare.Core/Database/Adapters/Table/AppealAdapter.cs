using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models;
using RealWare.Core.Database.Models.Encompass.Table;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Table
{
    public class AppealAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TblAppeal";

        public string[] IdentifierColumns => new string[] { "SeqId" };

        public string[] SortColums => new string[] { "ScheduleDate", "ScheduleStartTime" };

        public AppealAdapter(IDbConnection connection) : base(connection) { }

        public List<AppealDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<AppealDto>(query);
        }

        public List<KeyResultDto> GetAllUniqueKeysByTaxYear(decimal taxYear)
        {
            var selectClause = new string[] { "AppealNo AS KeyValue", "'APPEALNO' AS KeyType" };
            var whereClause = new string[]
            {
                "TaxYear = @TaxYear" ,
                "@Version between VERSTART and VEREND"
            };
            var parameters = new Dictionary<string, object>
            {
                { "@TaxYear", taxYear },
                { "@Version", $"{taxYear}1231999" }
            };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: selectClause,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<KeyResultDto>(query, parameters);
        }

        public List<AppealDto> GetAllByTaxYear(decimal taxYear)
            => GetAllByTaxYear(taxYear.ToString());
        public List<AppealDto> GetAllByTaxYear(string taxYear)
        {
            var whereClause = new string[] 
            { 
                "TaxYear = @TaxYear" ,
                "@Version between VERSTART and VEREND"
            };
            var parameters = new Dictionary<string, object> 
            { 
                { "@TaxYear", taxYear },
                { "@Version", $"{taxYear}1231999" }
            };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<AppealDto>(query, parameters);
        }

        public AppealDto GetBySeqId(decimal sequenceId)
        {
            var whereClause = new string[] { "SeqId = @SeqId" };
            var parameters = new Dictionary<string, object> { { "@SeqId", sequenceId } };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: null);

            return ExecuteQuery<AppealDto>(query, parameters)?.FirstOrDefault();
        }

        public AppealDto GetByAppealNo(decimal appealNo, string taxYear)
        {
            var whereClause = new string[] 
            { 
                "AppealNo = @AppealNo",
                "@Version between VERSTART and VEREND" 
            };

            var parameters = new Dictionary<string, object> 
            { 
                { "@AppealNo", appealNo },
                { "@Version", $"{taxYear}1231999" }
            };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: null);

            return ExecuteQuery<AppealDto>(query, parameters)?.FirstOrDefault();
        }
    }
}
