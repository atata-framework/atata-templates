using Atata;
using NUnit.Framework;

namespace $rootnamespace$
{
    [TestFixture]
    public class $safeitemrootname$
    {
        [SetUp]
        public void SetUp()
        {
            // Find information about AtataContext set-up on https://atata.io/getting-started/#set-up
            AtataContext.Configure()
                //.UseChrome()
                //    .WithArguments("start-maximized")
                //    .WithLocalDriverPath() // It is needed for .NET Core when you reference driver as a NuGet package.
                //.UseBaseUrl("SITE_URL")
                .UseCulture("en-US")
                .UseAllNUnitFeatures()
                .Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
