namespace tddkata4
{
    public class Round
    {
        public static Player Winner(PlayerSelection playerOne, PlayerSelection playerTwo)
        {
            if (playerOne == PlayerSelection.Scissors && playerTwo == PlayerSelection.Rock)
            {
                return Player.PlayerTwo;
            }
            if (playerOne == PlayerSelection.Paper && playerTwo == PlayerSelection.Scissors)
            {
                return Player.PlayerTwo;
            }
            if (playerOne == PlayerSelection.Rock && playerTwo == PlayerSelection.Paper)
            {
                return Player.PlayerTwo;
            }
            return Player.PlayerOne;
        }
    }
}