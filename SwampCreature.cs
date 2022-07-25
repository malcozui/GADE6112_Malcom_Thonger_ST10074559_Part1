using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    internal class SwampCreature : Enemy
    {
        public SwampCreature(int x, int y, int hp, int maxHp, int dmg, char symbol) 
            :base(x, y, hp, maxHp, dmg, symbol)
        {
            hp = 10;
            dmg = 1;
        }

        public override Movement ReturnMove(Movement movement = 0)
        {
            Random rndm = new Random();
            bool loop = false;
            int dir;
            do
            {
                dir = rndm.Next(4);
                if (cardinalTiles[dir] != TileType.EmptyTile)
                {
                    loop = true;
                }
            } while (loop);
            switch (dir)
            {
                case 0:
                    return Movement.Up;
                case 1:
                    return Movement.Down;
                case 2:
                    return Movement.Left;
                case 3:
                    return Movement.Right;
                default:
                    //Will never be called but the compiler throws an
                    //"not all code paths return a value" error if i dont add this
                    return Movement.NoMovement;
            }
        }
    }
}
