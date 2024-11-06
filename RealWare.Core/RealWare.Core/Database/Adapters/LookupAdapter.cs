using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Adapters.Lookup;
using System.Data;

namespace RealWare.Core.Database.Adapters
{
    public class LookupAdapter : BaseRealWareDatabaseAdapter
    {
        public readonly ImpsConditionTypeAdapter ImpsConditionType;
        public readonly ImpsExteriorTypeAdapter ImpsExteriorType;
        public readonly ImpsQualityAdapter ImpsQuality;
        public readonly ImpsResRoofCoverTypeAdapter ImpsResRoofCoverType;
        public readonly ImpsRoofTypeAdapter ImpsRoofType;

        public LookupAdapter(IDbConnection connection) : base(connection)
        {
            ImpsConditionType = new ImpsConditionTypeAdapter(connection);
            ImpsExteriorType = new ImpsExteriorTypeAdapter(connection);
            ImpsQuality = new ImpsQualityAdapter(connection);
            ImpsResRoofCoverType = new ImpsResRoofCoverTypeAdapter(connection);
            ImpsRoofType = new ImpsRoofTypeAdapter(connection);
        }
    }
}
