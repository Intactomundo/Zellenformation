using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using WForm3_Zellenformation;

namespace WForm3_Zellenformation
{
    public class Board
    {
        public int _size { get; set; }

        private bool[,] _board;

        public Board(int size)
        {
            _size = size;
            _board = new bool[_size, _size];
        }

        public bool GetCellValue(int row, int column)
        {
            if (row < 0 || row > _size - 1 || column < 0 || column > _size - 1)
            {
                return false;
            }
            else
            {
                return _board[row, column];
            }
        }
        public void SetCellValue (int row, int column, bool value)
        {
            _board[row, column] = value;
        }
        public void Clear()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    SetCellValue(i, j, false);
                }
            }
        }
        private int CalcNeighbourCount(int row, int column)
        {
            int count = 0;

            // Cell on the right of the Cells
            if (GetCellValue(row, column + 1) == true)
            {
                count++;
            }
            // Cell on the bottom right of the Cells
            if (GetCellValue(row + 1, column + 1) == true)
            {
                count++;
            }
            // Cell on the bottom of the Cells
            if (GetCellValue(row + 1, column) == true)
            {
                count++;
            }
            // Cells on the bottom left of the Cells
            if (GetCellValue(row + 1, column - 1) == true)
            {
                count++;
            }
            // Cells on the left of the Cells
            if (GetCellValue(row, column - 1) == true)
            {
                count++;
            }
            // Cells on the top left of the Cells
            if (GetCellValue(row - 1, column - 1) == true)
            {
                count++;
            }
            // Cells on the top of the Cells
            if (GetCellValue(row - 1, column) == true)
            {
                count++;
            }
            // Cells on the top right of the Cells
            if (GetCellValue(row - 1, column + 1) == true)
            {
                count++;
            }

            return count;
        }
        public void CalcNextGen()
        {
            bool[,] nextGenBoard = new bool[_size, _size];
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    if (_board[i, j] == true)
                    {
                        if (CalcNeighbourCount(i, j) >= 2 && CalcNeighbourCount(i, j) <= 3)
                        {
                            nextGenBoard[i, j] = true;
                        }
                    }
                    else
                    {
                        if (CalcNeighbourCount(i, j) == 3)
                        {
                            nextGenBoard[i, j] = true;
                        }
                    }
                }
            }
            _board = nextGenBoard;
        }
    }
}
