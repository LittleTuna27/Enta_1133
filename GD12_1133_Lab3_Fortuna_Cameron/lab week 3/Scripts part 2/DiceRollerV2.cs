using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_week_3.Scripts_part_2;

internal class DiceRollerV2
{

    internal int totalSides = 6;

    Random rollInstance = new Random();

    internal int currentTotalSides()//setting up a function to check what the current sides is before rolling
     { 
            return totalSides; //getting the value if it being changed by one of the dice
     }

    public int previousResults = 0;
    public int RandomDiceRoll() //telling function when called to retun a integer
    {
        //making it so the roll instance has a new random variable each time
        Random rollInstance = new Random();
        previousResults = rollInstance.Next(1, totalSides + 1);// setting up what the previous result will be
        return previousResults; // saving the random interger to the previous result 
    }
}
