// See https://aka.ms/new-console-template for more information
SnakeAndLadderGame.SnakeAndLadder snakeAndLadder = new SnakeAndLadderGame.SnakeAndLadder();
SnakeAndLadderGame.MultiplePlayersGame multiplePlayers1 = new SnakeAndLadderGame.MultiplePlayersGame("Player1");
SnakeAndLadderGame.MultiplePlayersGame multiplePlayers2 = new SnakeAndLadderGame.MultiplePlayersGame("Player2");

Console.WriteLine("Dice number obtained in rolling is --- " + snakeAndLadder.DiceRoll());
snakeAndLadder.PlayOptions();

while(multiplePlayers1.playerPosition<100 && multiplePlayers2.playerPosition < 100)
{
    multiplePlayers1.Play();

    if (multiplePlayers1.playerPosition == 100)
        {
            Console.Write("Player1 won");
            break;
        }
        
    Console.Write("  ||  ");
    multiplePlayers2.Play();

    if (multiplePlayers2.playerPosition == 100)
        {
            Console.Write("Player2 won");
        }
    Console.WriteLine();
    
}
