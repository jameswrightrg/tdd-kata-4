using NUnit.Framework;

namespace tddkata4.Tests
{
    [TestFixture]
    public class GameTests
    {
        [TestCase(PlayerSelection.Rock, PlayerSelection.Scissors, Winner.PlayerOne)]
        [TestCase(PlayerSelection.Scissors, PlayerSelection.Paper, Winner.PlayerOne)]
        [TestCase(PlayerSelection.Paper, PlayerSelection.Rock, Winner.PlayerOne)]
        [TestCase(PlayerSelection.Scissors, PlayerSelection.Rock, Winner.PlayerTwo)]
        [TestCase(PlayerSelection.Paper, PlayerSelection.Scissors, Winner.PlayerTwo)]
        [TestCase(PlayerSelection.Rock, PlayerSelection.Paper, Winner.PlayerTwo)]
        public void PlayersCanWin(PlayerSelection playerOne, PlayerSelection playerTwo, Winner winner)
        {
            Assert.That(Round.Winner(playerOne, playerTwo), Is.EqualTo(winner));
        }
    }
}
