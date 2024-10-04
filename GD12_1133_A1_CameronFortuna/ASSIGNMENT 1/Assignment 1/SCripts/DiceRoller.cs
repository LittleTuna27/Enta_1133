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
            public int totalSides; //how many sides the dice has
            public int previousResults = 0; //a variable for the dice result
            private Random rollInstance = new Random();//a instance for random in my dice roller

            public DiceRollerV1(int sides) //getting the integer from the list to see how amny sides there are
            {
                totalSides = sides;  //setting the integer from the list to the total sides of the dice
            }

            public int RandomDiceRoll()// a function to call for when they need the value of their roll
            {
                previousResults = rollInstance.Next(1, totalSides + 1);//saying that the previous results is = to the roll
                return previousResults;// returns said output so it can be called
            }
        }
    }
}
