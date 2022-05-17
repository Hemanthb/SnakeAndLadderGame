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
        const int noPlay = 0, ladder = 1, snake = 2;
        Random random = new Random();
        public int DiceRoll()
        {
            diceNo = random.Next(1,7);
            return diceNo;
        }

        public void PlayOptions()
        {
            switch (random.Next(0, 3))
            {
                case noPlay:
                    playerPostion += 0;
                    break;
                case ladder:
                    playerPostion += diceNo;
                    break;
                case snake:
                    playerPostion -= diceNo;
                    break ;
                 default:
                    break;
            }
            if (playerPostion < 0)
            {
                playerPostion = 0;
                Console.WriteLine("Player Position is " + playerPostion);
            }
            else
            {
                Console.WriteLine("Player Position is " + playerPostion);
            }
        }
    }
}
