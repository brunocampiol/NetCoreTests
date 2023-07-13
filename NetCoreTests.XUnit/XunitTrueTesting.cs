using Xunit;

namespace NetCoreTests.XUnit
{
    public class XunitTrueTesting
    {
        [Fact]
        public void IsTrueAndTrue()
        {
            Assert.True(true, "It is true");
        }

        [Fact]
        public void IsTrueButFalse()
        {
            Assert.True(false, "It was false");
        }
    }
}
