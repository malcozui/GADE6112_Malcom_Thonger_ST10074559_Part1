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
        protected TileType[] cardinalTiles = new TileType[4];
        protected char symbol;

        public enum Movement
        {
            Up,
            Down,
            Left,
            Right,
            NoMovement
        }
        public Character(int x, int y, int hp, int maxHp, int dmg, char symbol) 
            :base(x, y)
        {
            this.hp = hp;
            this.maxHp = maxHp;
            this.dmg = dmg;
            this.symbol = symbol;
        }

        #region Properties
        public int HP { get => hp; set => hp = value; }
        public int MaxHP { get => maxHp; set => maxHp = value; }
        public int Dmg { get => dmg; set => dmg = value; }
        public char Symbol { get => symbol; }
        public TileType[] CardinalTiles { get => cardinalTiles; set => cardinalTiles = value; }
        #endregion

        #region Methods
        public virtual void Attack(Character target)
        {
            target.hp -= dmg;
        }

        public bool IsDead() => (hp <= 0); //a lambda expression to return whether the player is dead or not.

        public virtual bool CheckRange(Character target)
        {
            return (DistanceTo(target) <= 1);
        }

        private int DistanceTo(Character target)
        {
            //takes the absolute differnece in x and y and adds them for total distance
            int xDif = Math.Abs(target.x - x);
            int yDif = Math.Abs(target.y - y);
            return xDif + yDif;
        }

        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.Up:
                    y += 1;
                    break;
                case Movement.Down:
                    y -= 1;
                    break;
                case Movement.Left:
                    x -= 1;
                    break;
                case Movement.Right:
                    x += 1;
                    break;
                case Movement.NoMovement:
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0);

        public abstract override string ToString();
        #endregion
    }
}
