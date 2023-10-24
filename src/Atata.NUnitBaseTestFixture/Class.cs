using Atata;
using NUnit.Framework;

namespace $rootnamespace$
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
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
            AtataContext.Current?.Dispose();
        }
    }
}
