using System;
using Xunit;

namespace XunitDemo.Test
{
    public class AssertingObjectTypes
    {
        [Fact]
        public void ShouldCreateNormalEnemy_SimpleExample()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(false);

            Assert.IsType(typeof(NormalEnemy), enemy);
        }

        [Fact]
        public void ShouldCreateNormalEnemy_Cast()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(false);

            NormalEnemy normalEnemy = Assert.IsType<NormalEnemy>(enemy);

            Assert.Equal(10, normalEnemy.Power);
        }
    }
}
