namespace tddkata4
{
    public class Round
    {
        public static Winner Winner(PlayerSelection playerOne, PlayerSelection playerTwo)
        {
            if (playerOne == PlayerSelection.Scissors && playerTwo == PlayerSelection.Rock)
            {
                return tddkata4.Winner.PlayerTwo;
            }
            if (playerOne == PlayerSelection.Paper && playerTwo == PlayerSelection.Scissors)
            {
                return tddkata4.Winner.PlayerTwo;
            }
            if (playerOne == PlayerSelection.Rock && playerTwo == PlayerSelection.Paper)
            {
                return tddkata4.Winner.PlayerTwo;
            }
            if (playerOne == PlayerSelection.Rock && playerTwo == PlayerSelection.Rock)
            {
                return tddkata4.Winner.Draw;
            }
            return tddkata4.Winner.PlayerOne;
        }
    }
}