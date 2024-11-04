using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RealWare.Core.Tests.Setup.Models;

namespace RealWare.Core.Tests.Setup
{
    public class TestSetup
    {
        const string CONFIG_FILE = "local-configuration.json";

        public static LocalConfigurationModel Config { get; private set; }

        public TestSetup()
        {
            if (!File.Exists(CONFIG_FILE))
            {
                var configJson = JsonConvert.SerializeObject(LocalConfigurationModel.GetDefault(), Formatting.Indented);

                File.WriteAllText(CONFIG_FILE, configJson);

                var configFilePath = Path.GetFullPath(CONFIG_FILE);

                throw new Exception($"local-configuration.json file not found. One was created at {configFilePath}. " +
                    $"Please fill in values with your local values for testing.");
            }

            var config = new ConfigurationBuilder()
                .AddJsonFile(CONFIG_FILE, optional: false, reloadOnChange: true)
                .Build();

            // Bind the entire configuration to the LocalConfigurationModel
            Config = new LocalConfigurationModel();
            config.Bind(Config);
        }
    }
}
