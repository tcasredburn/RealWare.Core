using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Adapters.Table;
using System.Data;

namespace RealWare.Core.Database.Adapters
{
    public class TableAdapter : BaseRealWareDatabaseAdapter
    {
        public readonly AcctAdapter Acct;
        public readonly AcctPropertyAddressAdapter AcctPropertyAddress;
        public readonly AppealAdapter Appeal;
        public readonly AppealAcctAdapter AppealAcct;
        public readonly AddressAdapter Address;
        public readonly PersonAdapter Person;

        public TableAdapter(IDbConnection connection) : base(connection)
        {
            Acct = new AcctAdapter(connection);
            AcctPropertyAddress = new AcctPropertyAddressAdapter(connection);
            Appeal = new AppealAdapter(connection);
            AppealAcct = new AppealAcctAdapter(connection);
            Address = new AddressAdapter(connection);
            Person = new PersonAdapter(connection);
        }
    }
}
