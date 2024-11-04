using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace RealWare.Core.API
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OptionDataResourceName
    {
        Account,
        RealAccount,
        Improvements,
        Neighborhood,
        LandAbstract,
        LandAttribute,
        NovIncrease,
        NewConstruction,
        PropertyAddress,
        Legal,
        LegalLocation,
        Note,
        Flag,
        GisCoordinate,
        Sales,
        SalesAffidavit,
        CustomApplication,
        TCL
    }
}
