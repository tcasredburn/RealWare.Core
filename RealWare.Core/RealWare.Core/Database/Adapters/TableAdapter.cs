using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Adapters.Table;
using System.Data;

namespace RealWare.Core.Database.Adapters
{
    public class TableAdapter : BaseRealWareDatabaseAdapter
    {
        public readonly AcctPropertyAddressAdapter AcctPropertyAddress;
        public readonly AppealAdapter Appeal;

        public TableAdapter(IDbConnection connection) : base(connection)
        {
            AcctPropertyAddress = new AcctPropertyAddressAdapter(connection);
            Appeal = new AppealAdapter(connection);
        }
    }
}
