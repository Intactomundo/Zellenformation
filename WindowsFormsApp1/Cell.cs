using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Cell
    {
        public Point Position { get; private set; }
        public Rectangle Bounds { get; private set; }

        public bool IsAlive { get; set; }

        public Cell(Point position)
        {
            Position = position;
            Bounds = new Rectangle(Position.X * Game1.CellSize, Position.Y * Game1.CellSize, Game1.CellSize, Game1.CellSize);

            IsAlive = false;
        }

        public void Update(MouseState mouseState)
        {
            if (Bounds.Contains(new Point(mouseState.X, mouseState.Y)))
            {
                // Make cells come alive with left-click, or kill them with right-click.
                if (mouseState.LeftButton == ButtonState.Pushed)
                {
                    IsAlive = true;
                }
                else if (mouseState.RightButton == ButtonState.Pushed)
                {
                    IsAlive = false;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (IsAlive)
            {
                spriteBatch.Draw(Game1.Pixel, Bounds, Color.Black);
            } // Don't draw anything if it's dead, since the default background color is white.
        }
    }
}
