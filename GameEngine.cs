using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    internal class GameEngine
    {
        private Map map;
        private static readonly char heroChar = 'ඞ', 
            emptyChar = '⠀', 
            swampCreatureChar = 'Ξ', 
            obstacleChar = '⣿';

        public GameEngine()
        {
            map = new Map(10, 15, 10, 15, 10);
        }
        
        #region Properties
        
        public Map Map { get => map; }

        #endregion

        #region Methods

        public bool MovePlayer(Character.Movement direction)
        {
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < map.MapWidth; i++)
            {
                for (int j = 0; j < map.MapHeight; j++)
                {
                    switch (map.p_Map[i, j].Type)
                    {
                        case Tile.TileType.Hero:
                            sb.Append(heroChar);
                            break;
                        case Tile.TileType.Enemy:
                            sb.Append(swampCreatureChar);
                            break;
                        case Tile.TileType.Gold:
                            //gold not implemented in part 1
                            break;
                        case Tile.TileType.Weapon:
                            //weapons not implimented in part 1
                            break;
                        case Tile.TileType.EmptyTile:
                            sb.Append(emptyChar);
                            break;
                        case Tile.TileType.Obstacle:
                            sb.Append(obstacleChar);
                            break;
                        default:
                            break;
                    }
                }
                sb.Append('\n');
            } 
            return sb.ToString();
        }

        #endregion
    }
}
