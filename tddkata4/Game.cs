namespace tddkata4
{
    public class Game
    {
        private int m_RoundCount = 0;

        private readonly IPlayer m_PlayerOne;
        private int m_PlayerOneWins = 0;

        private readonly IPlayer m_PlayerTwo;
        private int m_PlayerTwoWins = 0;

        public Game(IPlayer playerOne, IPlayer playerTwo)
        {
            m_PlayerOne = playerOne;
            m_PlayerTwo = playerTwo;
        }

        public Game() : this(new Player(PlayerSelection.Rock), new Player(PlayerSelection.Scissors))
        {
        }

        public void PlayRound()
        {
            ++m_RoundCount;
            var winner = Round.Winner(m_PlayerOne.Reveal(), m_PlayerTwo.Reveal());
            switch (winner)
            {
                case RoundWinner.PlayerOne:
                    ++m_PlayerOneWins;
                    break;
                case RoundWinner.PlayerTwo:
                    ++m_PlayerTwoWins;
                    break;
            }
        }

        public GameWinner Winner
        {
            get
            {
                if (m_RoundCount >= 3)
                {
                    if (m_PlayerOneWins > m_PlayerTwoWins)
                    {
                        return GameWinner.PlayerOne;
                    }
                    if (m_PlayerTwoWins > m_PlayerOneWins)
                    {
                        return GameWinner.PlayerTwo;
                    }
                }
                return GameWinner.None;
            }
        }
    }
}