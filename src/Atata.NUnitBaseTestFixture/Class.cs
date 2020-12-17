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
            AtataContext.Configure().Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
