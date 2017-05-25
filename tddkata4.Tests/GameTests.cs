using NUnit.Framework;

namespace tddkata4.Tests
{
    [TestFixture]
    public class GameTests
    {
        [TestCase(PlayerSelection.Rock, PlayerSelection.Scissors)]
        [TestCase(PlayerSelection.Scissors, PlayerSelection.Paper)]
        [TestCase(PlayerSelection.Paper, PlayerSelection.Rock)]
        public void PlayerOneCanWin(PlayerSelection playerOne, PlayerSelection playerTwo)
        {
            Assert.That(Round.Winner(playerOne, playerTwo), Is.EqualTo(Player.PlayerOne));
        }

        [Test]
        public void PlayerOneCanLose()
        {
            Assert.That(Round.Winner(PlayerSelection.Scissors, PlayerSelection.Rock), Is.EqualTo(Player.PlayerTwo));
        }
    }
}
