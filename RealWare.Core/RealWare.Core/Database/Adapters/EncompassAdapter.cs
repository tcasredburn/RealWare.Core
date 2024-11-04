using RealWare.Core.Database.Adapters.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RealWare.Core.Database.Adapters
{
    public class EncompassAdapter : BaseRealWareDatabaseAdapter
    {
        public readonly LookupAdapter Lookup;

        public EncompassAdapter(IDbConnection connection) : base(connection)
        {
            Lookup = new LookupAdapter(connection);
        }
    }
}
