using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    abstract class Tile
    {
        protected int x;
        protected int y;
        public enum TileType
        {
            Hero = 1,
            Enemy,
            Gold,
            Weapon
        }
        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected int X { get => x; set => value = x; }
        protected int Y { get => y; set => value = y; }
    }
}
