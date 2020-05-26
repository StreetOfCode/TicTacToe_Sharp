using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class WinChecker
    {
        public static int Check(char[][] field)
        {
            #region diagonals

            if (field[0][0] != ' '
                && field[0][0] == field[1][1]
                && field[0][0] == field[2][2])
                return field[0][0] == 'X' ? 0 : 1;

            if (field[0][2] != ' '
                && field[0][2] == field[1][1]
                && field[0][2] == field[2][0])
                return field[0][2] == 'X' ? 0 : 1;

            #endregion

            // ROWS
            if (field[0][0] != ' '
                && field[0][0] == field[0][1]
                && field[0][0] == field[0][2])
                return field[0][0] == 'X' ? 0 : 1;

            if (field[1][0] != ' '
                && field[1][0] == field[1][1]
                && field[1][0] == field[1][2])
                return field[1][0] == 'X' ? 0 : 1;

            if (field[2][0] != ' '
                && field[2][0] == field[2][1]
                && field[2][0] == field[2][2])
                return field[2][0] == 'X' ? 0 : 1;

            // COLUMNS
            if (field[0][0] != ' '
                && field[0][0] == field[1][0]
                && field[0][0] == field[2][0])
                return field[0][0] == 'X' ? 0 : 1;

            if (field[0][1] != ' '
                && field[0][1] == field[1][1]
                && field[0][1] == field[2][1])
                return field[0][1] == 'X' ? 0 : 1;

            if (field[0][2] != ' '
                && field[0][2] == field[1][2]
                && field[0][2] == field[2][2])
                return field[0][2] == 'X' ? 0 : 1;

            return -1;
        }
    }
}
