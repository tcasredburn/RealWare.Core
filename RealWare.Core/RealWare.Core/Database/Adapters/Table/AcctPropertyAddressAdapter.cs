using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Table;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using RealWare.Core.Database.Extensions;
using RealWare.Core.Database.Helpers;
using System;

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

            return ExecuteQuery<AcctPropertyAddressDto>(query, parameters)?.FirstOrDefault();
        }

        public List<string> GetAllDistinctCities(string taxYear = null)
        {
            var parameters = new Dictionary<string, object>();
            string[] whereClause = null;
            var returnColumn = new string[] { nameof(AcctPropertyAddressDto.PropertyCity) };

            if (taxYear != null)
            {
                whereClause = new string[] { "@Version between apa.VERSTART and apa.VEREND" };
                parameters.Add("@Version", $"{taxYear}1231999");
            }

            var activeOnlyJoin = RealWareSqlJoinsHelper.GetActiveAccountOnlyJoin(
                sourceAccountAliasAndName: "apa.AccountNo", 
                version: parameters.Count() == 0 ? $"{DateTime.Now.Year}1231999" : "@Version");

            var query = GetDefaultSelectQueryText(
                this,
                selectColumns: returnColumn,
                isDistinct: true,
                alias: "apa",
                joins: new[] { activeOnlyJoin },
                whereClause: whereClause,
                orderBy: returnColumn);

            return ExecuteQuery<AcctPropertyAddressDto>(query, parameters).Select(x=>x.PropertyCity).ToList();
        }

        public List<string> GetAllDistinctZipCodes(string taxYear = null)
        {
            var parameters = new Dictionary<string, object>();
            string[] whereClause = null;
            var returnColumn = new string[] { nameof(AcctPropertyAddressDto.PropertyZipCode) };

            if (taxYear != null)
            {
                whereClause = new string[] { "@Version between apa.VERSTART and apa.VEREND" };
                parameters.Add("@Version", $"{taxYear}1231999");
            }

            var activeOnlyJoin = RealWareSqlJoinsHelper.GetActiveAccountOnlyJoin(
                sourceAccountAliasAndName: "apa.AccountNo",
                version: parameters.Count() == 0 ? $"{DateTime.Now.Year}1231999" : "@Version");

            var query = GetDefaultSelectQueryText(
                this,
                selectColumns: returnColumn,
                isDistinct: true,
                alias: "apa",
                joins: new[] { activeOnlyJoin },
                whereClause: whereClause,
                orderBy: returnColumn);

            return ExecuteQuery<AcctPropertyAddressDto>(query, parameters).Select(x => x.PropertyZipCode).ToList();
        }
    }
}
