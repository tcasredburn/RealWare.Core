using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Adapters.Lookup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RealWare.Core.Database.Adapters
{
    public class LookupAdapter : BaseRealWareDatabaseAdapter
    {
        public readonly ImpsExteriorTypeAdapter ImpsExteriorType;

        public LookupAdapter(IDbConnection connection) : base(connection)
        {
            ImpsExteriorType = new ImpsExteriorTypeAdapter(connection);
        }
    }
}
