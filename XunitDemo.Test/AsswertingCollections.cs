using Xunit;

namespace XunitDemo.Test
{
    public class AsswertingCollections
    {
        [Fact]
        public void ShouldHaveNotEmptyDefaultWeapons()
        {
            var sut = new PlayerCharacter();

            Assert.All(sut.Weapons, weapons => Assert.False(string.IsNullOrWhiteSpace(weapons)));
        }

        [Fact]
        public void ShouldHaveLongBow()
        {
            var sut = new PlayerCharacter();

            Assert.Contains("Sword", sut.Weapons);
        }

        [Fact]
        public void ShouldNotHaveLongBow()
        {
            var sut = new PlayerCharacter();

            Assert.DoesNotContain("Swords", sut.Weapons);
        }

        [Fact]
        public void ShouldHaveAtLeastOneKindOfLongBow()
        {
            var sut = new PlayerCharacter();

            Assert.Contains(sut.Weapons, weapon => weapon.Contains("Sword"));
        }

        [Fact]
        public void ShouldHaveAllExpectedWeapons()
        {
            var sut = new PlayerCharacter();

            var expectedWeapons = new[]
            {
                "Long Bow",
                "Short Bow",
                "Long Sword",
                "Sword"
            };

            Assert.Equal(expectedWeapons, sut.Weapons);
        }
    }
}
