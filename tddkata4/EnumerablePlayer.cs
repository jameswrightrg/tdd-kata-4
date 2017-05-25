using System.Collections.Generic;

namespace tddkata4
{
    public class EnumerablePlayer : IPlayer
    {
        private readonly IEnumerator<PlayerSelection> m_PlayerSelectionEnumerator;

        public EnumerablePlayer(IEnumerable<PlayerSelection> playerSelections)
        {
            m_PlayerSelectionEnumerator = playerSelections.GetEnumerator();
        }

        public PlayerSelection Reveal()
        {
            m_PlayerSelectionEnumerator.MoveNext();
            return m_PlayerSelectionEnumerator.Current;
        }
    }
}