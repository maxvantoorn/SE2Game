using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameSE2
{
    class Map
    {
        public Size mapSize { get; set; }
        public Point goal { get; set; }

        public Map(Size mapsize, Point doel)
        {
            this.doel = doel;
            this.mapSize = mapSize;
        }
    }
}
