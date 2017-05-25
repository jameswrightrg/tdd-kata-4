namespace tddkata4
{
    public class Game
    {
        private int m_RoundCount = 0;

        private Player m_PlayerOne;
        private Player m_PlayerTwo;

        public Game(Player playerOne, Player playerTwo)
        {
            m_PlayerOne = playerOne;
            m_PlayerTwo = playerTwo;
        }

        public Game()
        {
        }

        public void PlayRound()
        {
            if (m_PlayerOne == null || m_PlayerOne.Reveal() != PlayerSelection.Rock)
                ++m_RoundCount;
        }

        public GameWinner Winner => m_RoundCount >= 3 ? GameWinner.PlayerOne : GameWinner.None;
    }
}