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

        [TestCase(PlayerSelection.Scissors, PlayerSelection.Rock)]
        [TestCase(PlayerSelection.Paper, PlayerSelection.Scissors)]
        [TestCase(PlayerSelection.Rock, PlayerSelection.Paper)]
        public void PlayerOneCanLoseScissorsAgainstRock(PlayerSelection playerOne, PlayerSelection playerTwo)
        {
            Assert.That(Round.Winner(playerOne, playerTwo), Is.EqualTo(Player.PlayerTwo));
        }
    }
}
