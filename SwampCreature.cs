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

        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {
            throw new NotImplementedException();
        }
    }
}
