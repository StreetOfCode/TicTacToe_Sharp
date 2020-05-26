using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Field
    {
        private char[][] field;

        public Field()
        {
            field = CreateNewField();
        }

        public void Reset()
        {
            field = CreateNewField();
        }

        public char GetField(int row, int column)
        {
            return field[row][column];
        }

        public void SetField(int row, int column, char c)
        {
            field[row][column] = c;
        }

        public char[][] ToCharTable()
        {
            return field.Select(a => a.ToArray()).ToArray();
        }

        private char[][] CreateNewField()
        {
            var field = new char[3][];
            for (var i = 0; i < 3; i++)
            {
                field[i] = new char[3];
                for (var j = 0; j < 3; j++)
                {
                    field[i][j] = ' ';
                }
            }

            return field;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(" |1|2|3|");
            for (var i = 0; i < 3; i++)
            {
                sb.Append($"{i + 1}|");
                for (var j = 0; j < 3; j++)
                {
                    sb.Append($"{field[i][j]}|");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
