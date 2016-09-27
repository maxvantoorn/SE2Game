using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameSE2
{
    class Enemy
    {
        public int hitpoints { get; set; }
        public Point location { get; set; }

        public Enemy(int hitpoints, Point location)
        {
            this.hitpoints = hitpoints;
            this.location = location;
        }

        public void UpdateEnemy()
        {

        }

        public void DrawEnemy(Graphics g)
        {

        }

    }
}
