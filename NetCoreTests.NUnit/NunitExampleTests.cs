using NUnit.Framework;

namespace NetCoreTests.NUnit
{
    public sealed class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Out.WriteLine("Setup");
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.Out.WriteLine("TearDown");
        }

        [Test]
        public void IsTrueAndTrue()
        {
            // Assemble
            // Act
            // Assert
            Assert.IsTrue(true, "It is true");
        }

        //[Test]
        //public void IsTrueButFalse()
        //{
        //    // Assemble
        //    // Act
        //    // Assert
        //    Assert.IsTrue(false, "It was false");
        //}
    }
}
