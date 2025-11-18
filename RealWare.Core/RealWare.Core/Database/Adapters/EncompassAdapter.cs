using RealWare.Core.Database.Adapters.Base;
using System.Data;

namespace RealWare.Core.Database.Adapters
{
    public class EncompassAdapter : BaseRealWareDatabaseAdapter
    {
        public readonly LookupAdapter Lookup;
        public readonly TableAdapter Table;
        public readonly TableNAdapter TableN;

        public EncompassAdapter(IDbConnection connection) : base(connection)
        {
            Lookup = new LookupAdapter(connection);
            Table = new TableAdapter(connection);
            TableN = new TableNAdapter(connection);
        }
    }
}
