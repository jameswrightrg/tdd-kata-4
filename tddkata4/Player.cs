namespace tddkata4
{
    public class Player
    {
        private readonly PlayerSelection m_ConstantSelection;

        public Player(PlayerSelection constantSelection)
        {
            m_ConstantSelection = constantSelection;
        }

        public PlayerSelection Reveal()
        {
            return m_ConstantSelection;
        }
    }
}