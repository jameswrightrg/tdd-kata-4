using NUnit.Framework;

namespace tddkata4.Tests
{
    [TestFixture]
    public class RoundTests
    {
        [TestCase(PlayerSelection.Rock, PlayerSelection.Scissors, RoundWinner.PlayerOne)]
        [TestCase(PlayerSelection.Scissors, PlayerSelection.Paper, RoundWinner.PlayerOne)]
        [TestCase(PlayerSelection.Paper, PlayerSelection.Rock, RoundWinner.PlayerOne)]
        [TestCase(PlayerSelection.Scissors, PlayerSelection.Rock, RoundWinner.PlayerTwo)]
        [TestCase(PlayerSelection.Paper, PlayerSelection.Scissors, RoundWinner.PlayerTwo)]
        [TestCase(PlayerSelection.Rock, PlayerSelection.Paper, RoundWinner.PlayerTwo)]
        public void PlayersCanWin(PlayerSelection playerOne, PlayerSelection playerTwo, RoundWinner roundWinner)
        {
            Assert.That(Round.Winner(playerOne, playerTwo), Is.EqualTo(roundWinner));
        }

        [TestCase(PlayerSelection.Rock)]
        [TestCase(PlayerSelection.Scissors)]
        [TestCase(PlayerSelection.Paper)]
        public void PlayersCanDraw(PlayerSelection playerSelection)
        {
            Assert.That(Round.Winner(playerSelection, playerSelection), Is.EqualTo(RoundWinner.Draw));
        }
    }
}
