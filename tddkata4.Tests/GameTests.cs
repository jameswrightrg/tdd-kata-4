using System;
using System.Linq;
using System.Media;
using System.Text;
using NUnit.Framework;

namespace tddkata4.Tests
{
    class GameTests
    {
        [Test]
        public void PlayerOneWinsAfterThreeRounds()
        {
            var game = new Game();

            game.PlayRound();
            game.PlayRound();
            game.PlayRound();

            Assert.That(game.Winner, Is.EqualTo(GameWinner.PlayerOne));
        }
        
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void NobodyWinsBeforeThreeRounds(int rounds)
        {
            var game = new Game();

            for (var i = 0; i < rounds; i++)
            {
                game.PlayRound();
            }

            Assert.That(game.Winner, Is.EqualTo(GameWinner.None));
        }

        [Test]
        public void NoOneWinsAfterThreeRounds()
        {
            var playerOne = new Player(PlayerSelection.Rock);
            var playerTwo = new Player(PlayerSelection.Rock);

            var game = new Game(playerOne, playerTwo);

            game.PlayRound();
            game.PlayRound();
            game.PlayRound();

            Assert.That(game.Winner, Is.EqualTo(GameWinner.None));
        }

        [Test]
        public void PlayerOneWinsAfterTieBreaker()
        {
            var playerOne = new EnumerablePlayer(new[] {PlayerSelection.Rock, PlayerSelection.Rock, PlayerSelection.Rock, PlayerSelection.Paper});
            var playerTwo = new Player(PlayerSelection.Rock);

            var game = new Game(playerOne, playerTwo);

            game.PlayRound();
            game.PlayRound();
            game.PlayRound();
            game.PlayRound();

            Assert.That(game.Winner, Is.EqualTo(GameWinner.PlayerOne));
        }

    }
}
