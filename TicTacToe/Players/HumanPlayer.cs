using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(char c)
            : base(c) { }

        public override void GetPlayerInput(out int row, out int column)
        {
            Console.Write($"{C} - make a move: ");
            var playerInput = Console.ReadLine();
            var playerInputSplit = playerInput.Split(" ");
            row = int.Parse(playerInputSplit[0]) - 1;
            column = int.Parse(playerInputSplit[1]) - 1;
        }
    }
}
