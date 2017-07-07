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
            // Find information about AtataContext set-up on https://atata-framework.github.io/getting-started/#set-up.
            AtataContext.Build().
                //UseChrome().
                //    WithArguments("disable-extensions", "no-sandbox", "start-maximized").
                //UseBaseUrl("SITE_URL").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                LogNUnitError().
                SetUp();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current.CleanUp();
        }
    }
}
