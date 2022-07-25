using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Malcom_Thonger_ST10074559_Part1
{
    abstract class Character : Tile
    {
        protected int hp;
        protected int maxHp;
        protected int dmg;
        protected Tile[] cardinalTiles = new Tile[4];
        public enum Movement
        {
            NoMovement,
            Up,
            Down,
            Left,
            Right
        }
        public Character(int x, int y, TileType tileType, int hp, int maxHp, int dmg) 
            :base(x, y, tileType)
        {
            this.hp = hp;
            this.maxHp = maxHp;
            this.dmg = dmg;
        }

        public virtual void Attack(Character target)
        {
            target.hp -= dmg;
        }

        public bool IsDead() => (hp <= 0);

        public virtual bool CheckRange(Character target)
        {
            return (DistanceTo(target) <= 1);
        }

        private int DistanceTo(Character target)
        {
            int xDif = Math.Abs(target.x - x);
            int yDif = Math.Abs(target.y - y);
            return xDif + yDif;
        }

        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.Left:
                    x -= 1;
                    break;
                case Movement.Right:
                    x += 1;
                    break;
                case Movement.Up:
                    y += 1;
                    break;
                case Movement.Down:
                    y -= 1;
                    break;
                case Movement.NoMovement:
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0);

        public abstract override string ToString();
    }
}
