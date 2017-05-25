using NUnit.Framework;

namespace tddkata4.Tests
{
    [TestFixture]
    public class GameTests
    {
        [TestCase(PlayerSelection.Rock, PlayerSelection.Scissors)]
        [TestCase(PlayerSelection.Scissors, PlayerSelection.Paper)]
        public void PlayerOneCanWin(PlayerSelection playerOne, PlayerSelection playerTwo)
        {
            Assert.That(Round.Winner(playerOne, playerTwo), Is.EqualTo(Player.PlayerOne));
        }
    }
}
