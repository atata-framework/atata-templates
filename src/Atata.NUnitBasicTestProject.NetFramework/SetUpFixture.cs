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
            // Find information about AtataContext set-up on https://atata.io/getting-started/#set-up
            AtataContext.GlobalConfiguration
                .UseChrome()
                    .WithArguments("start-maximized")
                .UseBaseUrl("https://atata.io/")
                .UseCulture("en-US")
                .UseAllNUnitFeatures()
                .AddScreenshotFileSaving()
                    .WithArtifactsFolderPath();

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }
    }
}
