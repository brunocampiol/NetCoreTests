using NetCoreTests.App.Services;
using NUnit.Framework;

namespace NetCoreTests.NUnit
{
    [TestFixture]
    public class GuidServiceTest
    {
        // By default, NUnit initializes only once per test class
        private readonly GuidService _sut = new();

        [Test]
        public void Guid_IsNotEmpty()
        {
            // Assamble
            // Act
            var id = _sut.Id;
            // Assert
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
            TestContext.Out.WriteLine(id); // id will be same for both tests cases
        }

        [Test]
        public void Guid_IsNotEmpty2()
        {
            // Assamble
            // Act
            var id = _sut.Id;
            // Assert
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
            TestContext.Out.WriteLine(id); // id will be same for both tests cases
        }
    }
}
