using Atata;
using NUnit.Framework;

namespace $safeprojectname$
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            string testEnvironmentAlias = TestContext.Parameters.Get("TestEnvironment", "local");
            string driverAlias = TestContext.Parameters.Get("DriverAlias", DriverAliases.Chrome);

            // Find information on AtataContext set-up on https://atata.io/getting-started/#set-up
            // Find information on Atata JSON configuration on https://github.com/atata-framework/atata-configuration-json
            // NOTE: Driver configuration is required.
            //       For example, install Selenium.WebDriver.ChromeDriver NuGet package.
            AtataContext.GlobalConfiguration
                .ApplyJsonConfig<AtataConfig>()
                .ApplyJsonConfig<AtataConfig>(environmentAlias: testEnvironmentAlias)
                .UseDriver(driverAlias);
        }
    }
}
