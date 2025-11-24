using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models;
using RealWare.Core.Database.Models.Encompass.Table;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Table
{
    public class AcctAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TblAcct";

        public string[] IdentifierColumns => new string[] { "SeqId" };

        public string[] SortColums => new string[] { "AccountNo" };

        public AcctAdapter(IDbConnection connection) : base(connection) { }

        public List<AcctDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<AcctDto>(query);
        }

        public List<KeyResultDto> GetAllUniqueKeysByTaxYear(decimal taxYear, bool? isActive = null)
            => GetAllUniqueKeysByTaxYear(taxYear.ToString(), isActive);
        public List<KeyResultDto> GetAllUniqueKeysByTaxYear(string taxYear, bool? isActive = null)
        {
            var selectClause = new string[] { "AccountNo AS KeyValue", "'ACCOUNTNO' AS KeyType" };
            var whereClause = new string[] { "@Version between VERSTART and VEREND" };
            var parameters = new Dictionary<string, object> { { "@Version", $"{taxYear}1231999" } };

            if (isActive.HasValue)
            {
                whereClause = whereClause.Concat(new string[] { "AcctStatusCode = @AcctStatusCode" }).ToArray();
                parameters.Add("@AcctStatusCode", isActive.Value ? "A" : "I");
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: selectClause,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: new string[] { "KeyValue" });

            return ExecuteQuery<KeyResultDto>(query, parameters);
        }

        public List<AcctDto> GetAllByTaxYear(decimal taxYear, bool? isActive = null)
            => GetAllByTaxYear(taxYear.ToString(), isActive);
        public List<AcctDto> GetAllByTaxYear(string taxYear, bool? isActive = null)
        {
            var whereClause = new string[] { "@Version between VERSTART and VEREND" };
            var parameters = new Dictionary<string, object> { { "@Version", $"{taxYear}1231999" } };

            if (isActive.HasValue)
            {
                whereClause = whereClause.Concat(new string[] { "AcctStatusCode = @AcctStatusCode" }).ToArray();
                parameters.Add("@AcctStatusCode", isActive.Value ? "A" : "I");
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<AcctDto>(query, parameters);
        }

        public AcctDto GetByAccountNo(string accountNo, decimal taxYear, bool? isActive = null)
            => GetByAccountNo(accountNo, taxYear, isActive);
        public AcctDto GetByAccountNo(string accountNo, string taxYear, bool? isActive = null)
        {
            var whereClause = new string[] { "AccountNo = @AccountNo", "@Version between VERSTART and VEREND" };
            var parameters = new Dictionary<string, object> {
                { "@AccountNo", accountNo },
                { "@Version", $"{taxYear}1231999" } 
            };

            if (isActive.HasValue)
            {
                whereClause = whereClause.Concat(new string[] { "AcctStatusCode = @AcctStatusCode" }).ToArray();
                parameters.Add("@AcctStatusCode", isActive.Value ? "A" : "I");
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<AcctDto>(query, parameters)?.FirstOrDefault();
        }

        public List<AcctDto> GetAllByParcelNo(string parcelNo, decimal taxYear, bool? isActive = null)
            => GetAllByParcelNo(parcelNo, taxYear.ToString(), isActive);
        public List<AcctDto> GetAllByParcelNo(string parcelNo, string taxYear, bool? isActive = null)
        {
            var whereClause = new string[] { "ParcelNo = @ParcelNo", "@Version between VERSTART and VEREND" };
            var parameters = new Dictionary<string, object> { 
                { "@ParcelNo", parcelNo },
                { "@Version", $"{taxYear}1231999" }
            };

            if (isActive.HasValue)
            {
                whereClause = whereClause.Concat(new string[] { "AcctStatusCode = @AcctStatusCode" }).ToArray();
                parameters.Add("@AcctStatusCode", isActive.Value ? "A" : "I");
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<AcctDto>(query, parameters);
        }
    }
}
