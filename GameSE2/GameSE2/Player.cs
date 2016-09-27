using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameSE2
{
    class Player
    {
        public string name { get; set; }
        public int hitpoints { get; set; }
        public Point location { get; set; }

        public Player (string name, int hitpoints, Point location)
        {
            this.name = name;
            this.hitpoints = hitpoints;
            this.location = location;
        }

        public void UpdatePlayer()
        {

        }

        public void DrawPlayer(Graphics g)
        {

        }
        
    }
}
