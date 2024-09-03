namespace RealWare.Core.API.Models.Base
{
    public interface ILandAbstract
    {
        string AbstractAdjCode
        {
            get;
        }

        string AbstractCode
        {
            get;
        }

        decimal? LandActualTotal
        {
            get;
        }

        string LandClass
        {
            get;
        }

        string LandSubClass
        {
            get;
        }

        decimal? NCTotalActualValue
        {
            get;
            set;
        }

        string TaxDistrict
        {
            get;
        }
    }
}
