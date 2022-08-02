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

        #endregion
    }
}
