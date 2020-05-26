using System;

namespace TicTacToe
{
    public class CPUPlayer : Player
    {
        private Random random;

        public CPUPlayer(char c)
            : base(c) 
        {
            random = new Random();
        }

        public override void GetPlayerInput(out int row, out int column)
        {
            row = random.Next(0, 3);
            column = random.Next(0, 3);
        }
    }
}
