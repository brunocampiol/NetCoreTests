using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetCoreTests.MsTest
{
    [TestClass]
    public class MstestTrueTesting
    {
        [TestMethod]
        public void IsTrueAndTrue()
        {
            Assert.IsTrue(true, "It is true");
        }

        [TestMethod]
        public void IsTrueButFalse()
        {
            Assert.IsTrue(false, "It was false!");
        }
    }
}
