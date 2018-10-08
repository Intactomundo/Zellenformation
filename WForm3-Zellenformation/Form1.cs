using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForm3_Zellenformation
{
    public partial class Form1 : Form
    {
        private Board _board;
        public bool CellAlive { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Form1_MinimumSize();
        }
        private void Form1_MinimumSize()
        {
            MinimumSize = new Size(735, 575);
            MaximumSize = new Size(735, 575);
        }
        public void Panel1_Grid()
        {
            CellAlive = false;
            var graph = panel1.CreateGraphics();
            int numOfCells = Convert.ToInt32(tb1di.Text);
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
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            _board = new Board(Convert.ToInt32(tb1di.Text));
            Panel1_Grid();
        }

        private void Btn1draw_MouseDown(object sender, MouseEventArgs e)
        {
            var p = panel1.CreateGraphics();
            p.Clear(Color.WhiteSmoke);
            Panel1_Grid();
        }

        private void Btn6cg_MouseDown(object sender, MouseEventArgs e)
        {
            var p = panel1.CreateGraphics();
            p.Clear(Color.WhiteSmoke);
            Panel1_Grid();
        }

        public void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int numOfCells = Convert.ToInt32(tb1di.Text);
            int cellSize = 501 / numOfCells;
            int ClickPosX = e.Location.X;
            int ClickPosY = e.Location.Y;
            int row = ClickPosX / cellSize;
            int column = ClickPosY / cellSize;
            int RowPos = row * cellSize;
            int ColumnPos = column * cellSize;
            Graphics draw = panel1.CreateGraphics();
            Rectangle round;
            if (e.Button == MouseButtons.Left)
            {
                round = new Rectangle(RowPos + 1, ColumnPos + 1, cellSize - 1, cellSize - 1);
                draw.DrawRectangle(new Pen(Brushes.Black), round);
                draw.FillRectangle(Brushes.LawnGreen, round);
                CellAlive = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                round = new Rectangle(RowPos + 1, ColumnPos + 1, cellSize - 1, cellSize - 1);
                draw.DrawRectangle(new Pen(Brushes.Black), round);
                draw.FillRectangle(Brushes.WhiteSmoke, round);
                CellAlive = false;
            }
        }
        private void Btn1draw_Click(object sender, EventArgs e)
        {
            _board = new Board(Convert.ToInt32(tb1di.Text));
        }
    }
}

