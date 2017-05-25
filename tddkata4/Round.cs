namespace tddkata4
{
    public class Round
    {
        public static RoundWinner Winner(PlayerSelection playerOne, PlayerSelection playerTwo)
        {
            if (playerOne == playerTwo)
            {
                return tddkata4.RoundWinner.Draw;
            }
            if (playerOne == PlayerSelection.Scissors && playerTwo == PlayerSelection.Rock)
            {
                return tddkata4.RoundWinner.PlayerTwo;
            }
            if (playerOne == PlayerSelection.Paper && playerTwo == PlayerSelection.Scissors)
            {
                return tddkata4.RoundWinner.PlayerTwo;
            }
            if (playerOne == PlayerSelection.Rock && playerTwo == PlayerSelection.Paper)
            {
                return tddkata4.RoundWinner.PlayerTwo;
            }
            return tddkata4.RoundWinner.PlayerOne;
        }
    }
}