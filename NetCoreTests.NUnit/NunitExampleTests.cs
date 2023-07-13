using NUnit.Framework;

namespace NetCoreTests.NUnit
{
    public class Tests
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
            // Assamble
            // Act
            // Assert
            Assert.IsTrue(true, "It is true");
        }

        [Test]
        public void IsTrueButFalse()
        {
            // Assamble
            // Act
            // Assert
            Assert.IsTrue(false, "It was false");
        }
    }
}
