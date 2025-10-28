using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Adapters.TableN;

namespace RealWare.Core.Database.Adapters
{
    public class TableNAdapter : BaseRealWareDatabaseAdapter
    {
        public readonly AdminAdapter Admin;
        public readonly AdminHeaderAdapter AdminHeader;

        public TableNAdapter(System.Data.IDbConnection connection) : base(connection) 
        { 
            Admin = new AdminAdapter(connection);
            AdminHeader = new AdminHeaderAdapter(connection);
        }
    }
}
