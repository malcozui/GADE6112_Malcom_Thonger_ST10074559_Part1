using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    internal class Hero : Character
    {
        public Hero(int x, int y, int hp, int maxHp, int dmg, char symbol) 
            :base(x, y, hp, maxHp, dmg, symbol)
        {

        }
        #region Methods
        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {
            if (move == Movement.NoMovement) return Movement.NoMovement;

            //checks if the tile in the cardinal direction is empty, if it is, it returns the given movement, else it returns no movement
            if (cardinalTiles[(int)move] != TileType.EmptyTile) return Movement.NoMovement;
            else return move;
        }

        public override string ToString()
        {
            return $"Player Stats: \nHP: {hp}/{maxHp} \nDamage: {dmg} \n[{x},{y}]";
        }
        #endregion
    }
}
