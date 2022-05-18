using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    class MultiplePlayersGame
    {
        public String playerName;
        public int diceNo, playerPosition = 0;
        const int noPlay = 0, ladder = 1, snake = 2;
        Random random = new Random();
        public MultiplePlayersGame(string playerName)
        {
            this.playerName = playerName;
        }


        public int DiceRoll()
        {
            diceNo = random.Next(1, 7);
            return diceNo;
        }
        public void Play()
        {
        repeat:
            int option = random.Next(3);
            switch (option)
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
                Console.Write(playerName + " Position is " + playerPosition);
            }
            else if (playerPosition > 100)
            {
                playerPosition -= diceNo;
                Console.Write(playerName + " Position is " + playerPosition);
            }
            else
            {
                Console.Write(playerName + " Position is " + playerPosition);
            }
            if (option == ladder)
            {
                if (playerPosition != 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("- - - - - - - - - - - - - - -");
                    Console.WriteLine(playerName+"Got to roll dice again as its ladder");
                    goto repeat;
                }
            }
        }

    }
}
