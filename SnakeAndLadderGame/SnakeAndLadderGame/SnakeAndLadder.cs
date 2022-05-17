using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class SnakeAndLadder
    {
        int diceNo,playerPostion=0,playerStartPosition = 0;
        Random random = new Random();
        public int DiceRoll()
        {
            diceNo = random.Next(1,7);
            return diceNo;
        }
    }
}
