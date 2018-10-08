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
    class Board
    {
        private static int _size { get; set; }

        public Board(int size)
        {
            _size = size;
        }

        bool[,] _board = new bool[_size, _size];

        public bool GetCellValue(int row, int column)
        {
            return _board[row, column];
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

            // Cells on the right of the Cells
            if (GetCellValue(row + 1, column) == true)
            {
                count++;
            }
            // Cells on the bottom right of the Cells
            if (GetCellValue(row + 1, column + 1) == true)
            {
                count++;
            }
            // Cells on the bottom of the Cells
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
                        if (CalcNeighbourCount(i, j) >= 2 || CalcNeighbourCount(i, j) <= 3)
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
