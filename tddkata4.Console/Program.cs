namespace tddkata4.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerOne = new ConsolePlayer();
            var playerTwo = new ConsolePlayer();

            var game = new Game(playerOne, playerTwo);
            while (true)
            {
                game.PlayRound();
                System.Console.WriteLine(game.Winner);
            }
        }
    }

    internal class ConsolePlayer : IPlayer
    {
        public PlayerSelection Reveal()
        {
            
            var input = System.Console.ReadLine();
            switch (input)
            {
                case "rock":
                    return PlayerSelection.Rock;
                case "scissors":
                    return PlayerSelection.Scissors;
                case "paper":
                    return PlayerSelection.Paper;
                default:
                    System.Console.WriteLine("Try again");
                    return Reveal();
            }
        }
    }
}
