using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.TableN;
using System;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.TableN
{
    public class AdminHeaderAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TbnAdminHeader";

        // From schema: PK on AccountNo + GroupAccountFlag + AdminNo + JurisdictionId
        public string[] IdentifierColumns => new[] { "AccountNo", "GroupAccountFlag", "AdminNo", "JurisdictionId" };

        public string[] SortColums => new[] { "AccountNo", "GroupAccountFlag" };

        public AdminHeaderAdapter(IDbConnection connection) : base(connection) { }

        public List<AdminHeaderDto> GetAllByAdminNo(decimal adminNo, decimal? jurisdictionId = null)
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

            return ExecuteQuery<AdminHeaderDto>(query, parameters);
        }

        public List<AdminHeaderDto> GetAllByAccountNo(string accountNo, decimal? adminNo = null, decimal? jurisdictionId = null)
        {
            var where = new List<string> { "AccountNo = @AccountNo" };
            var parameters = new Dictionary<string, object> { { "@AccountNo", accountNo } };

            if (adminNo.HasValue)
            {
                where.Add("AdminNo = @AdminNo");
                parameters.Add("@AdminNo", adminNo.Value);
            }

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

            return ExecuteQuery<AdminHeaderDto>(query, parameters);
        }

        public AdminHeaderDto GetMostRecentNOVByAccountNo(string accountNo, int? taxYear = null, int?[] allowedStatusAdminId = null)
        {
            var parameters = new Dictionary<string, object> { { "@AccountNo", accountNo } };

            if (allowedStatusAdminId == null || allowedStatusAdminId.Length == 0)
                allowedStatusAdminId = new int?[] { 5 }; // Default to Printed

            if(taxYear.HasValue)
                parameters.Add("@TaxYear", taxYear.Value);

            string query = @"
                SELECT TOP(1) ah.*
                FROM ASRPROD.ENCOMPASS.TBNADMIN a
                INNER JOIN ASRPROD.ENCOMPASS.TBNADMINHEADER ah on a.ADMINNO = ah.ADMINNO
                WHERE ADMINPROCESSTYPEID IN (1, 4) -- 1=REAL NOV, 4=PERSONAL NOV
                    " + (taxYear.HasValue ? "AND TAXYEAR = @TaxYear" : "") + @"     
                    AND STATUSADMINID IN (" + string.Join(",",allowedStatusAdminId)+ @")
                    AND ACCOUNTNO = @ACCOUNTNO
                ORDER BY NOTICEDATE DESC";

            var results = ExecuteQuery<AdminHeaderDto>(query, parameters);

            return results.Count > 0 ? results[0] : null;
        }

        public List<AdminHeaderMostRecentNOVDto> GetAllMostRecentNOVByTaxYear(int taxYear, int?[] allowedStatusAdminId = null)
        {
            var parameters = new Dictionary<string, object> { { "@TaxYear", taxYear } };

            if (allowedStatusAdminId == null || allowedStatusAdminId.Length == 0)
                allowedStatusAdminId = new int?[] { 5 }; // Default to Printed

            string query = @"
                SELECT AccountNo, MAX(NOTICEDATE) MostRecentNOVDate, MAX(ah.ADMINNO) AdminNo
                FROM ASRPROD.ENCOMPASS.TBNADMIN a
                INNER JOIN ASRPROD.ENCOMPASS.TBNADMINHEADER ah on a.ADMINNO = ah.ADMINNO
                WHERE ADMINPROCESSTYPEID IN (1, 4) -- 1=REAL NOV, 4=PERSONAL NOV
                    AND TAXYEAR = @TAXYEAR 
                    AND STATUSADMINID IN (" + string.Join(",", allowedStatusAdminId) + @")
                GROUP BY ACCOUNTNO";

            return ExecuteQuery<AdminHeaderMostRecentNOVDto>(query, parameters);
        }
    }
}
