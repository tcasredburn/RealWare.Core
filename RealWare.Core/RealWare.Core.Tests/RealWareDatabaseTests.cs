﻿using RealWare.Core.Database.Adapters.Lookup;
using RealWare.Core.Database.Adapters.Table;
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
        public void ImpsConditionTypeAdapter_GetAllActive_ShouldReturnValues(string taxYear)
        {
            var adapter = new ImpsConditionTypeAdapter(sqlConnection);

            var result = adapter.GetAllActive(taxYear);

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x => x.IsActive), "Should only be active status.");
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("2024")]
        public void ImpsExteriorTypeAdapter_GetAllActive_ShouldReturnValues(string taxYear)
        {
            var adapter = new ImpsExteriorTypeAdapter(sqlConnection);

            var result = adapter.GetAllActive(taxYear);

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x => x.IsActive), "Should only be active status.");
        }

        [TestMethod]
        public void ImpsQualityAdapter_GetAllActive_ShouldReturnValues()
        {
            var adapter = new ImpsQualityAdapter(sqlConnection);

            var result = adapter.GetAllActive();

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x => x.IsActive), "Should only be active status.");
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("Condo")]
        [DataRow("Duplex")]
        [DataRow("Residential")]
        public void ImpsResRoofCoverTypeAdapter_GetAllActive_ShouldReturnValues(string propertyType)
        {
            var adapter = new ImpsResRoofCoverTypeAdapter(sqlConnection);

            var result = adapter.GetAllActive();

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x=>x.IsActive), "Should only be active status.");
        }

        [TestMethod]
        public void ImpsRoofTypeAdapter_GetAllActive_ShouldReturnValues()
        {
            var adapter = new ImpsRoofTypeAdapter(sqlConnection);

            var result = adapter.GetAllActive();

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x => x.IsActive), "Should only be active status.");
        }

        [TestMethod]
        [DataRow(null,null)]
        [DataRow("2024", "Condo")]
        [DataRow("2024", "Agricultural")]
        [DataRow("2024", "Commercial")]
        [DataRow("2024", "Residential")]
        public void NbhdAdjustmentAdapter_GetAllActive_ShouldReturnValues(string taxYear, string propertyType)
        {
            var adapter = new NbhdAdjustmentAdapter(sqlConnection);

            var result = adapter.GetAllActive(taxYear, propertyType);

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x => x.IsActive), "Should only be active status.");
        }

        [TestMethod]
        public void LeaTypeAdapter_GetAllActive_ShouldReturnValues()
        {
            var adapter = new LEATypeAdapter(sqlConnection);

            var result = adapter.GetAllActive();

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x => x.IsActive), "Should only be active status.");
        }

        [TestMethod]
        public void EconomicAreaAdapter_GetAllActive_ShouldReturnValues()
        {
            var adapter = new EconomicAreaAdapter(sqlConnection);

            var result = adapter.GetAllActive();

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x => x.IsActive), "Should only be active status.");
        }

        [TestMethod]
        public void ValueAreaAdapter_GetAllActive_ShouldReturnValues()
        {
            var adapter = new ValueAreaAdapter(sqlConnection);

            var result = adapter.GetAllActive();

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x => x.IsActive), "Should only be active status.");
        }

        [TestMethod]
        public void SaleExcludeAdapter_GetAllActive_ShouldReturnValues()
        {
            var adapter = new SaleExcludeAdapter(sqlConnection);

            var result = adapter.GetAllActive();

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.TrueForAll(x => x.IsActive), "Should only be active status.");
        }


        [TestMethod]
        [DataRow(null)]
        [DataRow("2024")]
        public void AcctPropertyAddressAdapter_GetAllByAccountNo_ShouldReturnValues(string taxYear)
        {
            var testAccountNo = TestSetup.Config.TestAccountNo;

            var adapter = new AcctPropertyAddressAdapter(sqlConnection);

            var result = adapter.GetAllByAccountNo(testAccountNo, taxYear);

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.Count > 0, "No result returned.");
            Assert.IsTrue(result.First().AccountNo == testAccountNo, "Account number does not match.");
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("2024")]
        public void AcctPropertyAddressAdapter_GetByAccountNo_ShouldReturnSingleValue(string taxYear)
        {
            var testAccountNo = TestSetup.Config.TestAccountNo;

            var adapter = new AcctPropertyAddressAdapter(sqlConnection);

            var result = adapter.GetByAccountNo(testAccountNo, taxYear);

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.AccountNo == testAccountNo, "Account number does not match.");
        }

        [TestMethod]
        [DataRow("2024")]
        public void AcctPropertyAddressAdapter_GetByAccountNo_GetFormattedAddress(string taxYear)
        {
            var testAccountNo = TestSetup.Config.TestAccountNo;

            var adapter = new AcctPropertyAddressAdapter(sqlConnection);

            var result = adapter.GetByAccountNo(testAccountNo, taxYear);

            Assert.IsNotNull(result, "No result returned.");
            Assert.IsTrue(result.AccountNo == testAccountNo, "Account number does not match.");

            var formattedAddress = result.GetFormattedAddress();
            Assert.IsTrue(formattedAddress.Length > 3, "No formatted address returned.");

            var formattedStreetAddress = result.GetFormattedStreetAddress();
            Assert.IsTrue(formattedStreetAddress.Length > 3, "No formatted street address returned.");

            var formattedCityZip = result.GetFormattedCityZip();
            Assert.IsTrue(formattedCityZip.Length > 3, "No formatted city/zip returned.");
        }
    }
}
