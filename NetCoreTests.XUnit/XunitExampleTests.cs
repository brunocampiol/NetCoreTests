using Xunit;

namespace NetCoreTests.XUnit
{
    public class XunitExampleTests
    {
        [Fact]
        public void IsTrueAndTrue()
        {
            // Assamble
            // Act
            // Assert
            Assert.True(true, "It is true");
        }

        [Fact]
        public void IsTrueButFalse()
        {
            // Assamble
            // Act
            // Assert
            Assert.True(false, "It was false");
        }
    }
}
