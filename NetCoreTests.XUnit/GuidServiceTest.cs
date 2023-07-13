using NetCoreTests.App.Services;
using Xunit;
using Xunit.Abstractions;

namespace NetCoreTests.XUnit
{
    public class GuidServiceTest
    {
        // By default, xUnit is a transient type of intance.
        // Means it will have a new instance per test case.
        private readonly GuidService _sut = new();
        private readonly ITestOutputHelper _output;

        public GuidServiceTest(ITestOutputHelper output)
        {
                _output = output;
        }

        [Fact]
        public void Guid_IsNotEmpty()
        {
            // Assamble
            // Act
            var id = _sut.Id;
            // Assert
            Assert.NotEqual(Guid.Empty, id);
            _output.WriteLine(id.ToString()); // id will be different for both tests cases
        }

        [Fact]
        public void Guid_IsNotEmpty2()
        {
            // Assamble
            // Act
            var id = _sut.Id;
            // Assert
            Assert.NotEqual(Guid.Empty, id);
            _output.WriteLine(id.ToString()); // id will be different for both tests cases
        }
    }
}
