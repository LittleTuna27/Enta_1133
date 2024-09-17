using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Game_Porgramming.scirpts.scirpt
{
    public class DiceRoller
    {
        internal int totalSides = 6;

        internal int previousResults = 0;

        public void description()
        {
            Console.WriteLine("Rolls a six sided dice."); //text to explain action
            Console.WriteLine("Min Roll:"); //text to show
            Console.WriteLine("1");
            Console.WriteLine("Max Roll:");
            Console.WriteLine(totalSides);
        }

        public int randomDiceRoll() //telling function when called to retun a integer
        { 
            Random rollInstance = new Random(); //making it so the roll instance has a new random variable each time

            previousResults = rollInstance.Next(1, totalSides +1);// setting up what the previous result will be
            return previousResults; // saving the random interger to the previous result 
        }
        //Diceroler is a definition of what a something is, DoceRollerInstance is taking that definition and set a peramtor of what it is.
    }
}
