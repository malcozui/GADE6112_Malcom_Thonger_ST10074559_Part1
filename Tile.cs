using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    public abstract class Tile
    {
        protected int x;
        protected int y;
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
            EmptyTile,
            Obstacle
        }
        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #region Properties
        
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public TileType Type { get; set; }

        #endregion
    }
}
