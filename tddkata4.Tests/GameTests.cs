using NUnit.Framework;

namespace tddkata4.Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void RockBeatsScissors()
        {
            Assert.That(Round.Winner(PlayerSelection.Rock, PlayerSelection.Scissors), Is.EqualTo(Player.PlayerOne));
        }
    }
}
