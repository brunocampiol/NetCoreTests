using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NetCoreTests.MsTest
{
    [TestClass]
    public sealed class MstestExampleTests
    {
        [TestMethod]
        public void IsTrueAndTrue()
        {
            // Assemble
            // Act
            // Assert
            Assert.IsTrue(true, "It is true");
        }

        //[TestMethod]
        //public void IsTrueButFalse()
        //{
        //    // Assemble
        //    // Act
        //    // Assert
        //    Assert.IsTrue(false, "It was false!");
        //}
    }
}
