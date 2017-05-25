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

            Assert.That(game.Winner, Is.EqualTo(Winner.PlayerOne));
        }
    }
}
