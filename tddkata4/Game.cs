namespace tddkata4
{
    public class Game
    {
        private int m_RoundCount = 0;

        public void PlayRound()
        {
            ++m_RoundCount;
        }

        public GameWinner Winner => m_RoundCount >= 3 ? GameWinner.PlayerOne : GameWinner.None;
    }
}