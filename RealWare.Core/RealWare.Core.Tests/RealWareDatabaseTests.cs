using RealWare.Core.API;
using RealWare.Core.Database.Adapters.Lookup;
using RealWare.Core.Database.Models.Encompass.Lookup;
using RealWare.Core.Tests.Setup;
using System.Data.SqlClient;

namespace RealWare.Core.Tests
{
    [TestClass]
    public class RealWareDatabaseTests
    {
        SqlConnection sqlConnection { get; set; }

        [TestInitialize]
        public void SetUpDatabaseForTests()
        {
            // Required configuration setup
            // for localized testing parameters
            new TestSetup();

            // Create API class
            sqlConnection = new SqlConnection(TestSetup.Config.RealWareDatabaseConnectionString);
        }


        [TestMethod]
        [DataRow(null)]
        [DataRow("2024")]
        public void ImpsExteriorTypeAdapter_GetAllActive_ShouldReturnValues(string taxYear)
        {
            var adapter = new ImpsExteriorTypeAdapter(sqlConnection);

            var result = adapter.GetAllActive(taxYear);

            Assert.IsNotNull(result, "No result returned.");
        }
    }
}
