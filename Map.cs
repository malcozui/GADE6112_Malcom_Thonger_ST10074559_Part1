using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    internal class Map
    {
        private Tile[,] map;
        private Hero hero;
        private Enemy[] enemies;
        private int mapWidth, mapHeight;
        private Random rndm = new Random();
        
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyCount)
        {
            mapWidth = rndm.Next(minWidth, maxWidth);
            mapHeight = rndm.Next(minHeight, maxHeight);

            map = new Tile[mapWidth, mapHeight];

            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    if (i == 0 || i == mapWidth - 1) map[i, j] = new Obstacle(i, j);
                    else if (j == 0 || j == mapHeight - 1) map[i, j] = new Obstacle(i, j);
                    else map[i, j] = new EmptyTile(i, j);
                }
            }

            enemies = new Enemy[enemyCount];
        }

        #region Properties
        public Tile[,] p_Map { get => map; }
        public Hero p_Hero { get => hero; }
        public Enemy[] Enemies { get => enemies; }
        public int MapWidth { get => mapWidth; }
        public int MapHeight { get => mapHeight; }
        #endregion

        #region Methods
        public void UpdateVision()
        {
            //Hero vision
            hero.CardinalTiles
            //Enemies Vision

        }

        private void Create(Tile.TileType type)
        {
            bool loop = false;
            int rndmX, rndmY;
            do
            {
                rndmX = rndm.Next(mapWidth);
                rndmY = rndm.Next(mapHeight);

                loop = (map[rndmX, rndmY] is null || map[rndmX, rndmY] == null);
            } while (loop);
        }
        #endregion
    }
}
