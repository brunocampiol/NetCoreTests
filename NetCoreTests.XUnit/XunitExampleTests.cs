using Xunit;
using Xunit.Abstractions;

namespace NetCoreTests.XUnit
{
    public sealed class XunitExampleTests : IDisposable
    {
        private readonly ITestOutputHelper _output;

        public XunitExampleTests(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Setup");
        }

        public void Dispose() => _output.WriteLine("TearDown");

        [Fact]
        public void IsTrueAndTrue()
        {
            // Assemble
            // Act
            // Assert
            Assert.True(true, "It is true");
        }

        //[Fact]
        //public void IsTrueButFalse()
        //{
        //    // Assemble
        //    // Act
        //    // Assert
        //    Assert.True(false, "It was false");
        //}
    }
}
