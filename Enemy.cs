using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    abstract class Enemy : Character
    {
        protected object randomiser;
        protected char symbol;
        protected Enemy(int x, int y, int hp, int maxHp, int dmg, char symbol)
            : base(x, y, hp, maxHp, dmg)
        {
            this.symbol = symbol;
        }
        public override string ToString()
        {
            return $"Enemy at [{x},{y}] ({dmg})";
        }
    }
}
