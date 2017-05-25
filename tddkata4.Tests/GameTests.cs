using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
