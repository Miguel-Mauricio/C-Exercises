
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DiceGame
{
    public class Game
    {
        private Dice dice;
        private const int tries = 3;
        
        public Game(Dice dice1)
        {
            dice = dice1;
        }

        public void play()
        {
            var diceRoll = dice.Roll();
            var triesLeft= tries;
            Console.WriteLine("Guess the number. Rolling the dice...");
            Console.WriteLine("You have" + tries + " left.");

          

            while (triesLeft > 0)

            {
                Console.WriteLine("Enter a number:");
                var guess = UserInput.ReadNumber();
                if(guess == diceRoll)
                {
                    
                    break;
                }
                triesLeft--;

                Console.WriteLine("You guessed wrong, try again please.");
                Console.WriteLine("Tries left: " + triesLeft);
            }
        }

    }

}
