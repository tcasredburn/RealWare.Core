using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Table;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Table
{
    public class AddressAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TblAddress";

        public string[] IdentifierColumns => new string[] { "SeqId" };

        public string[] SortColums => new string[] { "City", "StateCode" };

        public AddressAdapter(IDbConnection connection) : base(connection) { }

        public List<AddressDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<AddressDto>(query);
        }

        public AddressDto GetBySeqId(decimal seqId)
        {
            var whereClause = new string[] { "SeqId = @SeqId" };
            var parameters = new Dictionary<string, object> { { "@SeqId", seqId } };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: null);

            return ExecuteQuery<AddressDto>(query, parameters)?.FirstOrDefault();
        }

        public AddressDto GetByAddressCode(decimal addressCode, decimal taxYear)
        {
            var whereClause = new string[]
            {
                "AddressCode = @AddressCode" ,
                "@Version between VERSTART and VEREND"
            };
            var parameters = new Dictionary<string, object>
            {
                { "@AddressCode", addressCode },
                { "@Version", $"{taxYear}1231999" }
            };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<AddressDto>(query, parameters)?.FirstOrDefault();
        }
    }

}
