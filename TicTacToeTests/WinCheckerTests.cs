using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Tests
{
    [TestClass()]
    public class WinCheckerTests
    {
        [TestMethod()]
        public void Check_EmptyField_NobodyWins()
        {
            var field = new char[][]
            {
                new char[] { ' ', ' ', ' '},
                new char[] { ' ', ' ', ' '},
                new char[] { ' ', ' ', ' '},
            };

            var expectedWinner = -1;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod()]
        public void Check_LeftToRightDiagonal_O()
        {
            var field = new char[][]
            {
                new char[] { 'O', ' ', ' '},
                new char[] { ' ', 'O', ' '},
                new char[] { ' ', ' ', 'O'},
            };

            var expectedWinner = 1;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod()]
        public void Check_LeftToRightDiagonal()
        {
            var field = new char[][]
            {
                new char[] { 'X', ' ', ' '},
                new char[] { ' ', 'X', ' '},
                new char[] { ' ', ' ', 'X'},
            };

            var expectedWinner = 0;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod()]
        public void Check_RightToLeftDiagonal()
        {
            var field = new char[][]
            {
                new char[] { ' ', ' ', 'X'},
                new char[] { ' ', 'X', ' '},
                new char[] { 'X', ' ', ' '},
            };

            var expectedWinner = 0;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod()]
        public void Check_FirstRow()
        {
            var field = new char[][]
            {
                new char[] { 'X', 'X', 'X'},
                new char[] { ' ', ' ', ' '},
                new char[] { ' ', ' ', ' '},
            };

            var expectedWinner = 0;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod()]
        public void Check_SecondRow()
        {
            var field = new char[][]
            {
                new char[] { ' ', ' ', ' '},
                new char[] { 'X', 'X', 'X'},
                new char[] { ' ', ' ', ' '},
            };

            var expectedWinner = 0;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod()]
        public void Check_ThirdRow()
        {
            var field = new char[][]
            {
                new char[] { ' ', ' ', ' '},
                new char[] { ' ', ' ', ' '},
                new char[] { 'X', 'X', 'X'},
            };

            var expectedWinner = 0;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }



        [TestMethod()]
        public void Check_FirstColumn()
        {
            var field = new char[][]
            {
                new char[] { 'X', ' ', ' '},
                new char[] { 'X', ' ', ' '},
                new char[] { 'X', ' ', ' '},
            };

            var expectedWinner = 0;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod()]
        public void Check_SecondColumn()
        {
            var field = new char[][]
            {
                new char[] { ' ', 'X', ' '},
                new char[] { ' ', 'X', ' '},
                new char[] { ' ', 'X', ' '},
            };

            var expectedWinner = 0;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod()]
        public void Check_ThirdColumn()
        {
            var field = new char[][]
            {
                new char[] { ' ', ' ', 'X'},
                new char[] { ' ', ' ', 'X'},
                new char[] { ' ', ' ', 'X'},
            };

            var expectedWinner = 0;
            var actualWinner = WinChecker.Check(field);

            Assert.AreEqual(expectedWinner, actualWinner);
        }
    }
}