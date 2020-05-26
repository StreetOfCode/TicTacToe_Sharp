namespace TicTacToe
{
    public abstract class Player
    {
        public char C { get; private set; }

        public Player(char c)
        {
            C = c;
        }

        public abstract void GetPlayerInput(out int row, out int column);
    }
}
