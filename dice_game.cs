using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            
            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                enemyRandomNum = random.Next(1, 7);
                System.Console.WriteLine("You rolled a " + playerRandomNum);
                System.Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); // delay 1s.
                System.Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);
                
                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    System.Console.WriteLine("Player wins this round");
                } 
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    System.Console.WriteLine("Enemy wins this round");
                }
                else
                {
                    System.Console.WriteLine("Draw!");
                }

                System.Console.WriteLine("The score is now - Player: " + playerPoints + ". Enemy: " + enemyPoints + ".");
                System.Console.WriteLine(); // blank line for readability
            }
            if (playerPoints > enemyPoints)
            {
                System.Console.WriteLine("You win!");
            }
            else if (playerPoints < enemyPoints)
            {
                System.Console.WriteLine("You lose!");
            }
            else 
            {
                System.Console.WriteLine("It's a draw!");
            }
            
            Console.ReadKey();
            
        }
    }
}