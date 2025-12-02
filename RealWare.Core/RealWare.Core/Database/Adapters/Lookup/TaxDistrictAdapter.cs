using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class TaxDistrictAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpTaxDistrict";

        public string[] IdentifierColumns => new string[] { "TaxDistrict", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder", "TaxDistrictName" };

        public TaxDistrictAdapter(IDbConnection connection) : base(connection) { }

        public List<TaxDistrictDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<TaxDistrictDto>(query);
        }

        public List<TaxDistrictDto> GetAllActive()
        {
            var whereClause = new string[] { "ActiveFlag != 0" };
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                isDistinct: true,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<TaxDistrictDto>(query);
        }
    }
}
