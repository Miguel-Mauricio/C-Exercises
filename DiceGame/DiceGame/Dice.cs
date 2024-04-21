using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Dice
    {
        private readonly Random random1;
        private const int sides = 6;

        public Dice(Random random)
        {
            random1 = random;
        }

        public int Roll()
        {
          return  random1.Next(1, sides + 1);
        }

    }
}
