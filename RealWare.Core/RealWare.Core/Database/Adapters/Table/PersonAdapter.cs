using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Table;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Table
{
    public class PersonAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TblPerson";

        public string[] IdentifierColumns => new string[] { "SeqId" };

        public string[] SortColums => new string[] { "Name1", "Name2" };

        public PersonAdapter(IDbConnection connection) : base(connection) { }

        public List<PersonDto> GetAll()
        {
            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: null,
                orderBy: SortColums);

            return ExecuteQuery<PersonDto>(query);
        }

        public PersonDto GetBySeqId(decimal seqId)
        {
            var whereClause = new string[] { "SeqId = @SeqId" };
            var parameters = new Dictionary<string, object> { { "@SeqId", seqId } };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: null);

            return ExecuteQuery<PersonDto>(query, parameters)?.FirstOrDefault();
        }

        public PersonDto GetByPersonCode(decimal personCode, decimal taxYear)
        {
            var whereClause = new string[]
            {
                "PersonCode = @PersonCode" ,
                "@Version between VERSTART and VEREND"
            };
            var parameters = new Dictionary<string, object>
            {
                { "@PersonCode", personCode },
                { "@Version", $"{taxYear}1231999" }
            };

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<PersonDto>(query, parameters)?.FirstOrDefault();
        }
    }
}
