using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.SCripts
{
    internal class DiceRoller
    {
        public class DiceRollerV1
        {
            public int totalSides;
            public int previousResults = 0;
            private Random rollInstance = new Random();

            public DiceRollerV1(int sides)
            {
                totalSides = sides;
            }

            public int RandomDiceRoll()
            {
                previousResults = rollInstance.Next(1, totalSides + 1);
                return previousResults;
            }
        }
    }
}
