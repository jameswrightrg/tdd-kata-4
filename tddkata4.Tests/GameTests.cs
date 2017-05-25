using NUnit.Framework;

namespace tddkata4.Tests
{
    [TestFixture]
    public class GameTests
    {
        [TestCase(PlayerSelection.Rock, PlayerSelection.Scissors, Player.PlayerOne)]
        [TestCase(PlayerSelection.Scissors, PlayerSelection.Paper, Player.PlayerOne)]
        [TestCase(PlayerSelection.Paper, PlayerSelection.Rock, Player.PlayerOne)]
        [TestCase(PlayerSelection.Scissors, PlayerSelection.Rock, Player.PlayerTwo)]
        [TestCase(PlayerSelection.Paper, PlayerSelection.Scissors, Player.PlayerTwo)]
        [TestCase(PlayerSelection.Rock, PlayerSelection.Paper, Player.PlayerTwo)]
        public void PlayersCanWin(PlayerSelection playerOne, PlayerSelection playerTwo, Player winningPlayer)
        {
            Assert.That(Round.Winner(playerOne, playerTwo), Is.EqualTo(winningPlayer));
        }
    }
}
