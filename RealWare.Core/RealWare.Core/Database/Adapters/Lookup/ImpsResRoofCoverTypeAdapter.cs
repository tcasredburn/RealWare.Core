using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Models.Encompass.Lookup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Lookup
{
    public class ImpsResRoofCoverTypeAdapter : BaseRealWareDatabaseAdapter, IRealWareDatabaseAdapter
    {
        public string TableName => "Encompass.TlkpImpsResRoofCoverType";

        public string[] IdentifierColumns => new string[] { "RoofCover", "PropertyType", "JurisdictionId" };

        public string[] SortColums => new string[] { "SortOrder" };

        public ImpsResRoofCoverTypeAdapter(IDbConnection connection) : base(connection) { }

        public List<ImpsResRoofCoverTypeDto> GetAllActive(string propertyType = null)
        {
            Dictionary<string, object> parameters = null;
            string[] whereClause = new string[] { "ActiveFlag != 0" };

            if (propertyType != null)
            {
                whereClause = whereClause.Concat(new string[] { "PropertyType = @PropertyType" }).ToArray();
                parameters = new Dictionary<string, object> { { "@PropertyType", propertyType } };
            }

            var query = GetDefaultSelectQueryText(this,
                selectColumns: null,
                whereClause: whereClause,
                orderBy: SortColums);

            return ExecuteQuery<ImpsResRoofCoverTypeDto>(query);
        }
    }
}
