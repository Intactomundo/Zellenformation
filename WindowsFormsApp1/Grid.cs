using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Grid
    {
        public Point Size { get; private set; }

        public int J => j;

        private Cell[,] cells;

        public Grid()
        {
            Size = new Point(Game1.CellsX, Game1.CellsY);

            cells = new Cell[Size.X, Size.Y];

            for (int i = 0; i < Size.X; i++)
                for (int j = 0; j < Size.Y; j++)
                    cells[i, j] = new Cell(new Point(i, j));
        }

        public void Update(GameTime gameTime)
        {
            (...)
    
        // Loop through every cell on the grid.
            for (int i = 0; i < Size.X; i++)
            {
                for (int j = 0; j < Size.Y; j++)
                {
                    // Check the cell's current state, and count its living neighbors.
                    bool living = cells[i, j].IsAlive;
                    int count = GetLivingNeighbors(i, j);
                    bool result = false;

                    // Apply the rules and set the next state.
                    if (living && count < 2)
                        result = false;
                    if (living && (count == 2 || count == 3))
                        result = true;
                    if (living && count > 3)
                        result = false;
                    if (!living && count == 3)
                        result = true;

                    cells[i, j].IsAlive = result;
                }
            }
        }
        public int GetLivingNeighbors(int x, int y)
        {
            int count = 0;

            // Check cell on the right.
            if (x != Size.X - 1)
                if (cells[x + 1, y].IsAlive)
                    count++;

            // Check cell on the bottom right.
            if (x != Size.X - 1 && y != Size.Y - 1)
                if (cells[x + 1, y + 1].IsAlive)
                    count++;

            // Check cell on the bottom.
            if (y != Size.Y - 1)
                if (cells[x, y + 1].IsAlive)
                    count++;

            // Check cell on the bottom left.
            if (x != 0 && y != Size.Y - 1)
                if (cells[x - 1, y + 1].IsAlive)
                    count++;

            // Check cell on the left.
            if (x != 0)
                if (cells[x - 1, y].IsAlive)
                    count++;

            // Check cell on the top left.
            if (x != 0 && y != 0)
                if (cells[x - 1, y - 1].IsAlive)
                    count++;

            // Check cell on the top.
            if (y != 0)
                if (cells[x, y - 1].IsAlive)
                    count++;

            // Check cell on the top right.
            if (x != Size.X - 1 && y != 0)
                if (cells[x + 1, y - 1].IsAlive)
                    count++;

            return count;
        }
        private bool[] NextCellStates;
        public void SetNextState()
        {
            for (int i = 0; i < Size.X; i++)
                for (int j = 0; j < Size.Y; j++)
                    cells[i, j].IsAlive = NextCellStates[i, j];
        }
    }
}
