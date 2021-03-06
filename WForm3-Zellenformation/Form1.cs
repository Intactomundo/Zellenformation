﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForm3_Zellenformation
{
    public partial class Window : Form
    {
        private Board _board;
        private string patternPath = ".\\..\\TextFiles";

        public Window()
        {
            InitializeComponent();
            WindowAutoSize();
        }

        private void WindowAutoSize()
        {
            MinimumSize = new Size(735, 575);
            MaximumSize = new Size(735, 575);
        }

        private void Window_Shown(object sender, EventArgs e)
        {
            _board = new Board(Convert.ToInt32(_dimensions.Text));
            DrawGrid();
            UpdatePatternList();
        }

        public void MainBoard_MouseClick(object sender, MouseEventArgs e)
        {
            int numOfCells = Convert.ToInt32(_dimensions.Text);
            int cellSize = 501 / numOfCells;
            int ClickPosX = e.Location.X;
            int ClickPosY = e.Location.Y;
            int row = ClickPosX / cellSize;
            int column = ClickPosY / cellSize;
            int RowPos = row * cellSize;
            int ColumnPos = column * cellSize;

            Graphics draw = _mainBoard.CreateGraphics();
            Rectangle round;

            if (e.Button == MouseButtons.Left)
            {
                round = new Rectangle(RowPos + 1, ColumnPos + 1, cellSize - 1, cellSize - 1);
                draw.DrawRectangle(new Pen(Brushes.Black), round);
                draw.FillRectangle(Brushes.LawnGreen, round);
                _board.SetCellValue(row, column, true);
            }

            else if (e.Button == MouseButtons.Right)
            {
                round = new Rectangle(RowPos + 1, ColumnPos + 1, cellSize - 1, cellSize - 1);
                draw.DrawRectangle(new Pen(Brushes.Black), round);
                draw.FillRectangle(Brushes.WhiteSmoke, round);
                _board.SetCellValue(row, column, false);
            }
        }
        private void DrawGrid_Click(object sender, EventArgs e)
        {
            _board = new Board(Convert.ToInt32(_dimensions.Text));
            var g = _mainBoard.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            _board.Clear();
            DrawGrid();
        }

        private void DrawGrid()
        {
            var graph = _mainBoard.CreateGraphics();
            int numOfCells = _board._size;
            int cellSizeY = 501 / numOfCells;
            int cellSizeX = 501 / numOfCells;

            Pen p = new Pen(Brushes.Black, 1);

            for (int y = 0; y < numOfCells + 1; y++)
            {
                graph.DrawLine(p, 0, y * cellSizeY, numOfCells * cellSizeY, y * cellSizeY);
            }

            for (int x = 0; x < numOfCells + 1; x++)
            {
                graph.DrawLine(p, x * cellSizeX, 0, x * cellSizeX, numOfCells * cellSizeX);
            }

            for (int i = 0; i < _board._size; i++)
            {
                for (int j = 0; j < _board._size; j++)
                {
                    if (_board.GetCellValue(i, j) == true)
                    {
                        int cellSize = 501 / numOfCells;
                        int RowPos = i * cellSize;
                        int ColumnPos = j * cellSize;

                        Graphics draw = _mainBoard.CreateGraphics();
                        var round = new Rectangle(RowPos + 1, ColumnPos + 1, cellSize - 1, cellSize - 1);
                        draw.DrawRectangle(new Pen(Brushes.Black), round);
                        draw.FillRectangle(Brushes.LawnGreen, round);
                    }
                    else
                    {
                        int cellSize = 501 / numOfCells;
                        int RowPos = i * cellSize;
                        int ColumnPos = j * cellSize;

                        Graphics draw = _mainBoard.CreateGraphics();
                        var round = new Rectangle(RowPos + 1, ColumnPos + 1, cellSize - 1, cellSize - 1);
                        draw.DrawRectangle(new Pen(Brushes.Black), round);
                        draw.FillRectangle(Brushes.WhiteSmoke, round);
                    }
                }
            }
            int livingCellsNum = _board.CountCells(true);
            var lCNText = Convert.ToString(livingCellsNum);
            _livingCellCounter.Text = lCNText;

            var GenerationCounter = Convert.ToString(_board._genNum);
            _genCounter.Text = GenerationCounter;

        }

        private void NextGen_Click(object sender, EventArgs e)
        {
            _genCounter.Text = string.Empty;
            _board.CalcNextGen();
            DrawGrid();
        }

        private void StartStopNextGen_MouseClick(object sender, MouseEventArgs e)
        {
            if (_startStopNextGen.Checked)
            {
                _myTimer.Enabled = true;
            }
            else
            {
                _myTimer.Enabled = false;
            }
        }

        private void InitializeMyTimer()
        {
            _myTimer.Tick += new EventHandler(_myTimer_Tick);
        }

        private void _myTimer_Tick(object sender, EventArgs e)
        {
            if (_myTimer.Enabled == true)
            {
                _board.CalcNextGen();
                DrawGrid();
            }
        }

        private void SavePattern_Click(object sender, EventArgs e)
        {
            StringBuilder line = new StringBuilder();
            for (int i = 0; i < _board._size; i++)
            {
                for (int j = 0; j < _board._size; j++)
                {
                    _board.GetCellValue(i, j);
                    if (_board.GetCellValue(i, j) == true)
                    {
                        line.Append($"{i},{j};");
                    }
                }
            }
            System.IO.File.WriteAllText(patternPath + "\\" + _patternList.Text + ".txt", line.ToString());
            UpdatePatternList();
        }

        private void UpdatePatternList()
        {
            _patternList.Items.Clear();
            var folder = new System.IO.DirectoryInfo(patternPath);
            var files = folder.GetFiles();

            var filenNames = files.Select(f => f.Name).ToArray();
            this._patternList.Items.AddRange(filenNames);
        }

        private void LoadPattern_Click(object sender, EventArgs e)
        {
            _board.Clear();
            DrawGrid();
            if ( new System.IO.FileInfo(patternPath + "\\" + _patternList.Text).Length == 0)
            {
                DrawGrid();
                MessageBox.Show("There was no data inside this .txt File.",
                "Failure Message");
            }
            else if (_patternList.Text == string.Empty)
            {
                DrawGrid();
                MessageBox.Show("You need to name the Textfile you want to load.",
                "Failure Message");
            }
            else
            {
                string[] lines = System.IO.File.ReadAllLines(patternPath + "\\" + _patternList.Text);

                var cellStrings = lines[0].Split(";".ToCharArray());
                for (int i = 0; i < cellStrings.Length; i++)
                {
                    if (cellStrings[i] != string.Empty)
                    {
                        var splitCellStrings = cellStrings[i].Split(",".ToCharArray());
                        int row;
                        int column;
                        if (int.TryParse(splitCellStrings[0], out row) && int.TryParse(splitCellStrings[1], out column))
                        {
                            _board.SetCellValue(row, column, true);
                        }
                        else
                        {
                            MessageBox.Show("There is wrong data inside the .txt File",
                            "Failure Message");
                            return;
                        }
                    }
                }
                DrawGrid();
            }
        }

        private void DeletePattern_Click(object sender, EventArgs e)
        {
            if (File.Exists(patternPath + "\\" + _patternList.Text))
            {
                File.Delete(patternPath + "\\" + _patternList.Text);
            }
            else
            {
                DrawGrid();
                MessageBox.Show("No file with such name exists in this directory.",
                "Failure Message");
            }
            UpdatePatternList();
        }
    }
}

