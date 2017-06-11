using Xunit;
namespace XunitDemo.Test
{
    public class AssertingNullBools
    {
        [Fact]
        public void ShouldHaveDefaultRandomGenerateName()
        {
            var sut = new PlayerCharacter();

            Assert.False(string.IsNullOrWhiteSpace(sut.Name));
        }

        [Fact]
        public void ShouldHaveNickName()
        {
            var sut = new PlayerCharacter();

            Assert.Null(sut.NickName);
        }

        [Fact]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }
    }
}
