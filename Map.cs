using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    internal class Map
    {
        private Tile[,] map = new Tile[15,8];
        private Hero hero;
        private Enemy[] enemies;
        private int mapWidth = 15, mapHeight = 8;
        private Random rndm;

        public Map()
        {
            
        }

        public Tile[,] MapProp { get => map; set => map = value; }
    }
}
