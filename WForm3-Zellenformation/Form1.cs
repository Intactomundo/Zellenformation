using System;
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
    public partial class _Window : Form
    {
        private Board _board;

        public _Window()
        {
            InitializeComponent();
            _WindowAutoSize();
        }
        private void _WindowAutoSize()
        {
            MinimumSize = new Size(735, 575);
            MaximumSize = new Size(735, 575);
        }
        private void _Window_Shown(object sender, EventArgs e)
        {
            _board = new Board(Convert.ToInt32(_dimensions.Text));
            DrawGrid();
        }
        public void _mainBoard_MouseClick(object sender, MouseEventArgs e)
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
        private void _drawGrid_Click(object sender, EventArgs e)
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
            var GenerationCounter = Convert.ToString(_board._genNum);
            _genCounter.Text = GenerationCounter;

        }

        private void _nextGen_Click(object sender, EventArgs e)
        {
            _genCounter.Text = string.Empty;
            _board.CalcNextGen();
            DrawGrid();
        }

        private void _startStopNextGen_MouseClick(object sender, MouseEventArgs e)
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

        private void _savePattern_Click(object sender, EventArgs e)
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
            System.IO.File.WriteAllText("C:\\Users\\Nicola Allenspach\\source\\repos\\Uni-SG\\WForm3-Zellenformation\\TextFiles\\" + _patternList.Text + ".txt", line.ToString());
        }

        private void _Window_Load_1(object sender, EventArgs e)
        {
            var folder = new System.IO.DirectoryInfo(@"C:\\Users\\Nicola Allenspach\\source\\repos\\Uni-SG\\WForm3-Zellenformation\\TextFiles");
            var files = folder.GetFiles();

            var filenNames = files.Select(f => f.Name).ToArray();
            this._patternList.Items.AddRange(filenNames);
        }
        private void _loadPattern_Click(object sender, EventArgs e)
        {
            _board.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\Nicola Allenspach\\source\\repos\\Uni-SG\\WForm3-Zellenformation\\TextFiles\\" + _patternList.Text);
            var cellStrings = lines[0].Split(";".ToCharArray());
            for (int i = 0; i < cellStrings.Length - 1; i++)
            {
                var splitCellStrings = cellStrings[i].Split(",".ToCharArray());
                var row = Convert.ToInt32(splitCellStrings[0]);
                var column = Convert.ToInt32(splitCellStrings[1]);
                _board.SetCellValue(row, column, true);
            }
            DrawGrid();
        }
        private void _deletePattern_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\\Users\\Nicola Allenspach\\source\\repos\\Uni-SG\\WForm3-Zellenformation\\TextFiles\\" + _patternList.Text);
        }

        private void _patterListTimer_Tick(object sender, EventArgs e)
        {
            _patternList.Items.Clear();
            _Window_Load_1(sender, e);
        }
    }
}

