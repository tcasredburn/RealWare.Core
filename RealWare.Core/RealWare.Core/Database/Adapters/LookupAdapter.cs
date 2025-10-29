using RealWare.Core.Database.Adapters.Base;
using RealWare.Core.Database.Adapters.Lookup;
using System.Data;

namespace RealWare.Core.Database.Adapters
{
    public class LookupAdapter : BaseRealWareDatabaseAdapter
    {
        public readonly DeedTypeAdapter DeedType;
        public readonly DocumentTypeAdapter DocumentType;
        public readonly EconomicAreaAdapter EconomicArea;
        public readonly ImpsConditionTypeAdapter ImpsConditionType;
        public readonly ImpsExteriorTypeAdapter ImpsExteriorType;
        public readonly ImpsOccTypeAdapter ImpsOccType;
        public readonly ImpsQualityAdapter ImpsQuality;
        public readonly ImpsResRoofCoverTypeAdapter ImpsResRoofCoverType;
        public readonly ImpsRoofTypeAdapter ImpsRoofType;
        public readonly LEATypeAdapter LEAType;
        public readonly NbhdAdjustmentAdapter NbhdAdjustment;
        public readonly OptionFieldAdapter OptionField;
        public readonly PrimaryUseCodeAdapter PrimaryUseCode;
        public readonly PropertyClassAdapter PropertyClass;
        public readonly SaleConfirmMethodAdapter SaleConfirmMethod;
        public readonly SaleExcludeAdapter SaleExclude;
        public readonly ValueAreaAdapter ValueArea;

        public LookupAdapter(IDbConnection connection) : base(connection)
        {
            DeedType = new DeedTypeAdapter(connection);
            DocumentType = new DocumentTypeAdapter(connection);
            EconomicArea = new EconomicAreaAdapter(connection);
            ImpsConditionType = new ImpsConditionTypeAdapter(connection);
            ImpsExteriorType = new ImpsExteriorTypeAdapter(connection);
            ImpsOccType = new ImpsOccTypeAdapter(connection);
            ImpsQuality = new ImpsQualityAdapter(connection);
            ImpsResRoofCoverType = new ImpsResRoofCoverTypeAdapter(connection);
            ImpsRoofType = new ImpsRoofTypeAdapter(connection);
            LEAType = new LEATypeAdapter(connection);
            NbhdAdjustment = new NbhdAdjustmentAdapter(connection);
            OptionField = new OptionFieldAdapter(connection);
            PrimaryUseCode = new PrimaryUseCodeAdapter(connection);
            PropertyClass = new PropertyClassAdapter(connection);
            SaleConfirmMethod = new SaleConfirmMethodAdapter(connection);
            SaleExclude = new SaleExcludeAdapter(connection);
            ValueArea = new ValueAreaAdapter(connection);
        }
    }
}
