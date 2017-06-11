using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitDemo.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAdd()
        {
            var sut = new Calculator();
            var result = sut.Add(1,2);

            Assert.Equal(3, result);
        }
    }
}
