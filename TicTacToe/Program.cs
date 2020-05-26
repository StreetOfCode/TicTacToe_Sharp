using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            var field = new Field();
            Player player1 = new HumanPlayer('X');
            Player player2 = new CPUPlayer('O');

            Console.WriteLine(field);

            var players = new[] { player1, player2 };
            var player = 0;
            while (true)
            {
                var currentPlayer = players[player];
                // "1 2" --> row = 1 a column = 2
                int row, column;
                currentPlayer.GetPlayerInput(out row, out column);

                while (row < 0 || row > 2
                    || column < 0 || column > 2
                    || field.GetField(row, column) != ' ')
                {
                    currentPlayer.GetPlayerInput(out row, out column);
                }

                field.SetField(row, column, currentPlayer.C);

                Console.WriteLine(field);

                player = player == 0 ? 1 : 0;

                var winner = WinChecker.Check(field.ToCharTable());
                if (winner != -1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"The winner is: {(winner == 0 ? player1.C : player2.C)}");
                    Console.WriteLine("Congratulations!!!");
                    Console.WriteLine("Do you wish to play again? (y - yes, n - no)");
                    var input = Console.ReadLine();
                    if (input != "y")
                        break;

                    field.Reset();
                    Console.WriteLine(field);
                    player = 0;
                }
            }
        }
    }
}
