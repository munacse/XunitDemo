using Xunit;

namespace XunitDemo.Test
{
    public class AssertingNumericResults
    {
        [Fact]
        public void ShouldAddIntValues()
        {
            var sut = new Calculator();

            Assert.Equal(3, sut.AddInts(1, 2));
        }

        [Fact]
        public void ShouldAddDoubleValues()
        {
            var sut = new Calculator();

            Assert.NotEqual(3.5, sut.AddDoubles(1.1, 2.2),1);
        }
    }
}
