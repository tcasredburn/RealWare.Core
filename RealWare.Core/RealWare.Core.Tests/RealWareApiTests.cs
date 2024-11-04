using RealWare.Core.API;
using RealWare.Core.API.Connection;
using RealWare.Core.Tests.Setup;

namespace RealWare.Core.Tests
{
    [TestClass]
    public class RealWareApiTests
    {
        RealWareApi api { get; set; }

        [TestInitialize]
        public void SetUpApiForTests()
        {
            // Required configuration setup
            // for localized testing parameters
            new TestSetup();

            // Create API class
            var connection = new RealWareApiConnection(
                TestSetup.Config.RealWareApiUrl,
                TestSetup.Config.RealWareApiToken);
            api = new RealWareApi(connection);
        }

        [TestMethod]
        public void PingAsync_ShouldReturnServerTime()
        {
            var result = api.PingAsync().Result;

            Assert.IsNotNull(result?.ServerTime, "No result returned.");
        }


        #region Option Data
        [TestMethod]
        [DataRow(OptionDataResourceName.Account)]
        [DataRow(OptionDataResourceName.RealAccount)]
        [DataRow(OptionDataResourceName.Improvements)]
        [DataRow(OptionDataResourceName.Neighborhood)]
        [DataRow(OptionDataResourceName.LandAbstract)]
        [DataRow(OptionDataResourceName.LandAttribute)]
        [DataRow(OptionDataResourceName.NovIncrease)]
        [DataRow(OptionDataResourceName.NewConstruction)]
        [DataRow(OptionDataResourceName.PropertyAddress)]
        [DataRow(OptionDataResourceName.Legal)]
        [DataRow(OptionDataResourceName.LegalLocation)]
        [DataRow(OptionDataResourceName.Note)]
        [DataRow(OptionDataResourceName.Flag)]
        [DataRow(OptionDataResourceName.GisCoordinate)]
        [DataRow(OptionDataResourceName.Sales)]
        [DataRow(OptionDataResourceName.SalesAffidavit)]
        [DataRow(OptionDataResourceName.CustomApplication)]
        [DataRow(OptionDataResourceName.TCL)]
        public void GetOptionDataAsync_ShouldReturnData(OptionDataResourceName resourceName)
        {
            var result = api.GetOptionDataAsync(resourceName).Result;

            Assert.IsNotNull(resourceName, "No result returned.");
        }
        #endregion
    }
}
