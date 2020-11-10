using Atata;
using NUnit.Framework;

namespace $safeprojectname$
{
    [TestFixture]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            // Find information about AtataContext set-up on https://atata.io/getting-started/#set-up
            AtataContext.Configure()
                //.UseChrome()
                //    .WithArguments("start-maximized")
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
