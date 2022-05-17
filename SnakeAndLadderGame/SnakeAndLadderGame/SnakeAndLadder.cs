using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class SnakeAndLadder
    {
        int diceNo,playerPosition=0,playerStartPosition = 0;
        const int noPlay = 0, ladder = 1, snake = 2;
        Random random = new Random();
        public int DiceRoll()
        {
            diceNo = random.Next(1,7);
            return diceNo;
        }

        public void PlayOptions()
        {
            while (playerPosition < 100)
            {
                switch (random.Next(0, 3))
                {
                    case noPlay:
                        playerPosition += 0;
                        break;
                    case ladder:
                        playerPosition += DiceRoll();
                        break;
                    case snake:
                        playerPosition -= DiceRoll();
                        break;
                    default:
                        break;
                }
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                    Console.WriteLine("Player Position is " + playerPosition);
                }
                else if (playerPosition > 100)
                {
                    playerPosition -= diceNo;
                    Console.WriteLine("Player Position is " + playerPosition);
                }
                else if(playerPosition == 100)
                {
                    Console.WriteLine("Player reached the 100th position and Won the game");
                }
                else
                {
                    Console.WriteLine("Player Position is " + playerPosition);
                }
                }
        }
    }
}
