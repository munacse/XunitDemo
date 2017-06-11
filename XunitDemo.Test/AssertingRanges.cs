using System;
using Xunit;

namespace XunitDemo.Test
{
    public class AssertingRanges
    {
        [Fact]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter { Health = 100 };

            sut.Sleep();

            Assert.InRange(sut.Health, 101, Int32.MaxValue);
        }
    }
}
