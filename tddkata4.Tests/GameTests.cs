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
        [Test]
        public void ScissorsBeatsPaper()
        {
            Assert.That(Round.Winner(PlayerSelection.Scissors, PlayerSelection.Paper), Is.EqualTo(Player.PlayerOne));
        }
    }
}
