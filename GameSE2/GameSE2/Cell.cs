using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameSE2
{
    class Cell
    {
        public Point location;
        public Size size;
        public bool wall;

        public Cell(Point location, Size size, bool wall)
        {
            this.location = location;
            this.size = size;
            this.wall = wall;
        }
    }

}
