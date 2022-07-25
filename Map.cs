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
                    if (i == 0 || i == mapWidth - 1)
                    {
                        map[i, j] = new Obstacle(i, j);
                        map[i, j].Type = Tile.TileType.Obstacle;
                    }
                    else if (j == 0 || j == mapHeight - 1)
                    {
                        map[i, j] = new Obstacle(i, j);
                        map[i, j].Type = Tile.TileType.Obstacle;
                    }
                    else
                    {
                        map[i, j] = new EmptyTile(i, j);
                        map[i, j].Type = Tile.TileType.EmptyTile; 
                    }
                }
            }
            enemies = new Enemy[enemyCount];

            Create(Tile.TileType.Hero);
            for (int i = 0; i < enemyCount; i++)
            {
                Create(Tile.TileType.Enemy);
            }

            UpdateVision();
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
            Tile.TileType[] tmp = new Tile.TileType[4];
            tmp[0] = map[hero.X, hero.Y + 1].Type; //up
            tmp[1] = map[hero.X, hero.Y - 1].Type; //down
            tmp[2] = map[hero.X - 1, hero.Y].Type; //left
            tmp[3] = map[hero.X + 1, hero.Y].Type; //right
            hero.CardinalTiles = tmp;

            //Enemies Vision
            for (int i = 0; i < enemies.Length; i++)
            {
                Tile.TileType[] enemiesTmp = new Tile.TileType[4];
                enemiesTmp[0] = map[enemies[i].X, enemies[i].Y + 1].Type; //up
                enemiesTmp[1] = map[enemies[i].X, enemies[i].Y - 1].Type; //down
                enemiesTmp[2] = map[enemies[i].X - 1, enemies[i].Y].Type; //left
                enemiesTmp[3] = map[enemies[i].X + 1, enemies[i].Y].Type; //right
                enemies[i].CardinalTiles = enemiesTmp;
            }
        }

        private void Create(Tile.TileType type)
        {
            bool loop;
            int rndmX, rndmY;
            do
            {
                rndmX = rndm.Next(mapWidth);
                rndmY = rndm.Next(mapHeight);

                loop = (map[rndmX, rndmY] is null || map[rndmX, rndmY] == null);
            } while (loop);
            switch (type)
            {
                case Tile.TileType.Hero:
                    hero.X = rndmX;
                    hero.Y = rndmY;
                    map[rndmX, rndmY] = hero;
                    map[rndmX, rndmY].Type = type;
                    break;
                case Tile.TileType.Enemy:
                    map[rndmX, rndmY] = new SwampCreature(rndmX, rndmY, 10, 10, 1, '〠') { Type = type };
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
