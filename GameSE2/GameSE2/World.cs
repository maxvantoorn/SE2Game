using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSE2
{
    class World
    {
        public bool GameWon { get; set; }
        public bool GameLoose { get; set; }
        public Player player { get; set; }
        public List<Enemy> EnemyList { get; set; }
        public List<Map> MapList { get; set; }

        public World()
        {

        }

        public void UpdateWorld()
        {

        }
    }
}
