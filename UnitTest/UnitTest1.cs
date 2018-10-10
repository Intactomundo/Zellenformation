using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WForm3_Zellenformation;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClearMethodClearsAllCells()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(4, 3, true);
            board.SetCellValue(1, 1, true);
            board.SetCellValue(5, 5, true);

            //act
            board.Clear();

            //assert
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Assert.AreEqual(false, board.GetCellValue(row, column));
                }
            }
        }
        [TestMethod]
        public void GetCellValueGetsCorrectCellValue()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(4, 3, true);

            //assert
            Assert.AreEqual(true, board.GetCellValue(4, 3));
        }
        [TestMethod]
        public void SetCellValueSetsCorrectCellValue()
        {
            //arrange
            var board = new Board(10);

            //act
            board.SetCellValue(4, 3, true);

            //assert
            Assert.AreEqual(true, board.GetCellValue(4, 3));
        }
        [TestMethod]
        public void CalcNextGenCalculatesCorrectNextGen1()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(2, 3, true);
            board.SetCellValue(3, 3, true);
            board.SetCellValue(4, 3, true);

            //act
            board.CalcNextGen();

            //assert
            Assert.AreEqual(true, board.GetCellValue(3, 2));
            Assert.AreEqual(true, board.GetCellValue(3, 3));
            Assert.AreEqual(true, board.GetCellValue(3, 4));
            Assert.AreEqual(false, board.GetCellValue(2, 3));
            Assert.AreEqual(false, board.GetCellValue(4, 3));
            Assert.AreEqual(97, board.CountCells(false));

        }
        [TestMethod]
        public void CalcNextGenCalculatesCorrectNextGen2()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(2, 3, true);
            board.SetCellValue(3, 3, true);
            board.SetCellValue(4, 3, true);
            board.SetCellValue(3, 2, true);
            board.SetCellValue(3, 4, true);
            board.CalcNextGen();

            //assert
            Assert.AreEqual(true, board.GetCellValue(2, 2));
            Assert.AreEqual(true, board.GetCellValue(2, 3));
            Assert.AreEqual(true, board.GetCellValue(2, 4));
            Assert.AreEqual(true, board.GetCellValue(3, 2));
            Assert.AreEqual(true, board.GetCellValue(3, 4));
            Assert.AreEqual(true, board.GetCellValue(4, 2));
            Assert.AreEqual(true, board.GetCellValue(4, 3));
            Assert.AreEqual(true, board.GetCellValue(4, 4));
            Assert.AreEqual(false, board.GetCellValue(3, 3));
            Assert.AreEqual(92, board.CountCells(false));
        }
        [TestMethod]
        public void CalcNextGenCalculatesCorrectNextGen3()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(2, 3, true);
            board.SetCellValue(3, 3, true);
            board.SetCellValue(2, 4, true);
            board.SetCellValue(3, 4, true);

            //act
            board.CalcNextGen();

            //assert
            Assert.AreEqual(true, board.GetCellValue(2, 3));
            Assert.AreEqual(true, board.GetCellValue(3, 3));
            Assert.AreEqual(true, board.GetCellValue(2, 4));
            Assert.AreEqual(true, board.GetCellValue(3, 4));
            Assert.AreEqual(96, board.CountCells(false));

        }
        [TestMethod]
        public void CalcNextGenCalculatesCorrectNextGen4()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(2, 2, true);
            board.SetCellValue(3, 2, true);
            board.SetCellValue(2, 3, true);
            board.SetCellValue(4, 5, true);
            board.SetCellValue(5, 5, true);
            board.SetCellValue(5, 4, true);

            //act
            board.CalcNextGen();

            //assert
            Assert.AreEqual(true, board.GetCellValue(2, 2));
            Assert.AreEqual(true, board.GetCellValue(3, 2));
            Assert.AreEqual(true, board.GetCellValue(2, 3));
            Assert.AreEqual(true, board.GetCellValue(4, 5));
            Assert.AreEqual(true, board.GetCellValue(5, 5));
            Assert.AreEqual(true, board.GetCellValue(5, 4));
            Assert.AreEqual(true, board.GetCellValue(4, 4));
            Assert.AreEqual(true, board.GetCellValue(3, 3));
            Assert.AreEqual(92, board.CountCells(false));

        }
        [TestMethod]
        public void CalcNextGenCalculatesCorrectNextGen5()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(0, 0, true);
            board.SetCellValue(0, 1, true);
            board.SetCellValue(0, 2, true);

            //act
            board.CalcNextGen();

            //assert
            Assert.AreEqual(true, board.GetCellValue(0, 1));
            Assert.AreEqual(true, board.GetCellValue(1, 1));
            Assert.AreEqual(98, board.CountCells(false));

        }
        [TestMethod]
        public void CalcNextGenCalculatesCorrectNextGen6()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(2, 2, true);
            board.SetCellValue(2, 3, true);
            board.SetCellValue(3, 1, true);
            board.SetCellValue(3, 2, true);
            board.SetCellValue(4, 1, true);

            //act
            board.CalcNextGen();

            //assert
            Assert.AreEqual(true, board.GetCellValue(2, 1));
            Assert.AreEqual(true, board.GetCellValue(2, 2));
            Assert.AreEqual(true, board.GetCellValue(2, 3));
            Assert.AreEqual(true, board.GetCellValue(3, 1));
            Assert.AreEqual(true, board.GetCellValue(3, 3));
            Assert.AreEqual(true, board.GetCellValue(4, 1));
            Assert.AreEqual(true, board.GetCellValue(4, 2));
            Assert.AreEqual(93, board.CountCells(false));

        }
        [TestMethod]
        public void CalcNextGenCalculatesCorrectNextGen7()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(3, 3, true);
            board.SetCellValue(3, 4, true);
            board.SetCellValue(3, 5, true);
            board.SetCellValue(3, 6, true);
            board.SetCellValue(4, 3, true);
            board.SetCellValue(4, 6, true);
            board.SetCellValue(5, 3, true);
            board.SetCellValue(5, 6, true);
            board.SetCellValue(6, 3, true);
            board.SetCellValue(6, 4, true);
            board.SetCellValue(6, 5, true);
            board.SetCellValue(6, 6, true);

            //act
            board.CalcNextGen();

            //assert
            Assert.AreEqual(true, board.GetCellValue(2, 4));
            Assert.AreEqual(true, board.GetCellValue(2, 5));
            Assert.AreEqual(true, board.GetCellValue(3, 3));
            Assert.AreEqual(true, board.GetCellValue(3, 4));
            Assert.AreEqual(true, board.GetCellValue(3, 5));
            Assert.AreEqual(true, board.GetCellValue(3, 6));
            Assert.AreEqual(true, board.GetCellValue(4, 2));
            Assert.AreEqual(true, board.GetCellValue(4, 3));
            Assert.AreEqual(true, board.GetCellValue(4, 6));
            Assert.AreEqual(true, board.GetCellValue(4, 7));
            Assert.AreEqual(true, board.GetCellValue(5, 2));
            Assert.AreEqual(true, board.GetCellValue(5, 3));
            Assert.AreEqual(true, board.GetCellValue(5, 6));
            Assert.AreEqual(true, board.GetCellValue(5, 7));
            Assert.AreEqual(true, board.GetCellValue(6, 3));
            Assert.AreEqual(true, board.GetCellValue(6, 4));
            Assert.AreEqual(true, board.GetCellValue(6, 5));
            Assert.AreEqual(true, board.GetCellValue(6, 6));
            Assert.AreEqual(true, board.GetCellValue(7, 4));
            Assert.AreEqual(true, board.GetCellValue(7, 5));
            Assert.AreEqual(80, board.CountCells(false));

        }
        [TestMethod]
        public void CalcNextGenCalculatesCorrectNextGen8()
        {
            //arrange
            var board = new Board(10);
            board.SetCellValue(9, 5, true);
            board.SetCellValue(8, 5, true);
            board.SetCellValue(8, 6, true);
            board.SetCellValue(8, 7, true);
            board.SetCellValue(8, 8, true);
            board.SetCellValue(7, 8, true);
            board.SetCellValue(6, 8, true);
            board.SetCellValue(5, 8, true);
            board.SetCellValue(5, 9, true);

            //act
            board.CalcNextGen();

            //assert
            Assert.AreEqual(true, board.GetCellValue(9, 5));
            Assert.AreEqual(true, board.GetCellValue(8, 5));
            Assert.AreEqual(true, board.GetCellValue(8, 6));
            Assert.AreEqual(true, board.GetCellValue(7, 6));
            Assert.AreEqual(true, board.GetCellValue(9, 7));
            Assert.AreEqual(true, board.GetCellValue(8, 7));
            Assert.AreEqual(true, board.GetCellValue(6, 7));
            Assert.AreEqual(true, board.GetCellValue(8, 8));
            Assert.AreEqual(true, board.GetCellValue(7, 8));
            Assert.AreEqual(true, board.GetCellValue(7, 9));
            Assert.AreEqual(true, board.GetCellValue(6, 8));
            Assert.AreEqual(true, board.GetCellValue(5, 8));
            Assert.AreEqual(true, board.GetCellValue(5, 9));
            Assert.AreEqual(87, board.CountCells(false));
        }
        [TestMethod]
        public void CountCellsCountsRightNumberOfCells()
        {
            //arrange
            var board = new Board(5);
            board.SetCellValue(0, 0, true);
            board.SetCellValue(1, 1, true);
            board.SetCellValue(3, 3, true);

            //assert
            Assert.AreEqual(22, board.CountCells(false));
        }
    }
}
