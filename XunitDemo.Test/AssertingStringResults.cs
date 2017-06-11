using Xunit;

namespace XunitDemo.Test
{
    public class AssertingStringResults
    {
        [Fact]
        public void ShouldJoinName()
        {
            var sut = new NameJoiner();

            Assert.Equal("Muna Jame", sut.Join("Muna", "Jame"));
        }

        [Fact]
        public void ShouldJoinName_CaseSensative()
        {
            var sut = new NameJoiner();

            Assert.Equal("Muna Jame", sut.Join("muna", "jame"),ignoreCase: true);
        }

        [Fact]
        public void ShouldJoinName_ContainsCheck()
        {
            var sut = new NameJoiner();

            Assert.Contains("Jame", sut.Join("Muna", "Jame"));
        }

        [Fact]
        public void ShouldJoinName_StartWith()
        {
            var sut = new NameJoiner();

            Assert.StartsWith("Muna", sut.Join("Muna", "Jame"));
        }

        [Fact]
        public void ShouldJoinName_EndWith()
        {
            var sut = new NameJoiner();

            Assert.EndsWith("ame", sut.Join("Muna", "Jame"));
        }

        [Fact]
        public void ShouldJoinName_Regex()
        {
            var sut = new NameJoiner();

            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", sut.Join("Muna", "Jame"));
        }
    }
}
