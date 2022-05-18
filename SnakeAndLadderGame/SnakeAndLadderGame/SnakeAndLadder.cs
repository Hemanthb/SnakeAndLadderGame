using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class SnakeAndLadder
    {
        int diceNo,playerPosition=0,noOfTimesDiceRolled = 0;
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
                        noOfTimesDiceRolled++;
                        break;
                    case snake:
                        playerPosition -= DiceRoll();
                        noOfTimesDiceRolled++;
                        break;
                    default:
                        break;
                }
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                    Console.WriteLine("Player Position is " + playerPosition +" || Times dice rolled is "+noOfTimesDiceRolled);
                }
                else if (playerPosition > 100)
                {
                    playerPosition -= diceNo;

                    while (playerPosition < 100)
                    {
                        Console.WriteLine("Player Position is " + playerPosition + " || Times dice rolled is " + noOfTimesDiceRolled);
                        if (DiceRoll() == (100 - playerPosition))
                        {
                            noOfTimesDiceRolled++;
                            playerPosition = 100;
                            Console.WriteLine("Player reached the 100th position and Won the game in " + noOfTimesDiceRolled + " dice rolls!");
                            
                        }
                        else
                        {
                            noOfTimesDiceRolled++;
                            continue;
                        }
                    }
                    
                }
                else if(playerPosition == 100)
                {
                    Console.WriteLine("Player reached the 100th position and Won the game in "+noOfTimesDiceRolled+" dice rolls!");
                }
                else
                {
                    Console.WriteLine("Player Position is " + playerPosition + " || Times dice rolled is " + noOfTimesDiceRolled);
                }
                }
        }
    }
}
