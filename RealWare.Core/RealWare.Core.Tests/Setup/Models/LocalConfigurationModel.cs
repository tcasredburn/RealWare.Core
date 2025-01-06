
namespace RealWare.Core.Tests.Setup.Models
{
    public class LocalConfigurationModel
    {
        // RealWare API values
        public string RealWareApiUrl { get; set; }
        public string RealWareApiToken { get; set; }
        public string RealWareApiUsername { get; set; }
        public string RealWareApiPassword { get; set; }

        // RealWare database connnection values
        public string RealWareDatabaseConnectionString { get; set; }

        // Test values
        public int TestTaxYear { get; set; }
        public string TestAccountNo { get; set; }
        public string TestAppealAccountNo { get; set; }
        public decimal TestAppealNo { get; set; }
        public decimal TestAddressCode { get; set; }
        public decimal TestPersonCode { get; set; }

        internal static LocalConfigurationModel GetDefault()
        {
            return new LocalConfigurationModel()
            {
                RealWareApiUrl = "http://{your-realware-server}/Test/EncompassAPI/",
                RealWareApiToken = "{your-test-realware-token}",
                RealWareApiUsername = "{your-test-realware-login-name}",
                RealWareApiPassword = "{your-test-realware-password}",
                RealWareDatabaseConnectionString = "Server={your-server-name};Database={your-database-name};Integrated Security=True;",
                TestTaxYear = DateTime.Now.Year
            };
        }
    }
}
