using System;
using Xunit;

namespace XunitDemo.Test
{
    public class AssertingExceptions
    {
        [Fact]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.Throws<DivideByZeroException>(() => sut.Divide(10, 0));
        }

        [Fact]
        public void ShouldErrorWhenNumberTooBig()
        {
            var sut = new Calculator();

            ArgumentOutOfRangeException thrownException = 
                Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide(205, 1));

            Assert.Equal("value", thrownException.ParamName);
        }
    }
}
