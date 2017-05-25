namespace tddkata4.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerOne = new ConsolePlayer(1);
            var playerTwo = new ConsolePlayer(2);

            var game = new Game(playerOne, playerTwo);
            var round = 1;
            while (true)
            {
                System.Console.WriteLine($"Round {round++}!");
                game.PlayRound();
                System.Console.WriteLine($"Winner: {game.Winner}");
                System.Console.WriteLine();
            }
        }
    }

    internal class ConsolePlayer : IPlayer
    {
        private readonly int m_PlayerNumber;

        public ConsolePlayer(int playerNumber)
        {
            m_PlayerNumber = playerNumber;
        }

        public PlayerSelection Reveal()
        {
            System.Console.WriteLine($"Player {m_PlayerNumber}, enter your selection:");
            var input = System.Console.ReadLine();
            switch (input)
            {
                case "rock":
                case "r":
                    return PlayerSelection.Rock;
                case "scissors":
                case "s":
                    return PlayerSelection.Scissors;
                case "paper":
                case "p":
                    return PlayerSelection.Paper;
                default:
                    System.Console.WriteLine("Try again");
                    return Reveal();
            }
        }
    }
}
