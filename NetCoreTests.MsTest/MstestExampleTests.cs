using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetCoreTests.MsTest
{
    [TestClass]
    public sealed class MstestExampleTests
    {
        [TestMethod]
        public void IsTrueAndTrue()
        {
            // Assamble
            // Act
            // Assert
            Assert.IsTrue(true, "It is true");
        }

        //[TestMethod]
        //public void IsTrueButFalse()
        //{
        //    // Assamble
        //    // Act
        //    // Assert
        //    Assert.IsTrue(false, "It was false!");
        //}
    }
}
