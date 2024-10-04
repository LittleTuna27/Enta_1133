using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_1.SCripts.DiceRoller;

namespace Assignment_1.SCripts
{
    public class ComputerProfile
    {
        public int computerResult = 0;
        public int computerScore = 0;
        public int computerScoreTotal = 0;
        public int computerDicePicked = 0;
        public int computerEvenRolls = 0;
        public int computerOddRolls = 0;
        public int computerAverageResult = 0;

        List<DiceRollerV1> computerDiceList = new List<DiceRollerV1>
        {

            new DiceRollerV1(6),
            new DiceRollerV1(8),
            new DiceRollerV1(12),
            new DiceRollerV1(20),

         };
        public int AverageComputerRolls()//a function to check that after 4 rounds what was roughly the averadge rolls they had by deviding their final score by 4
        {
            computerAverageResult = computerScoreTotal / 4;//a varible thats result id deviding the final score by 4 being the number of rounds i could chang out that number if needed
            return computerAverageResult;//return the result aback to call later
        }
        public void DiceReturn() //a function for if they select a unavalible dice or a imput that isnt allowed to reset the choice
        {
            CPUDiceSelect();//getting the random computer input on which weapon it will use
            CPUDiceHas();//doing the result of said action
        }
        internal int CPUDiceSelect()//set up random dice roll to select which of the dice it will use
        {
            Random computerChoice = new Random(); //instance for new random
            computerDicePicked = computerChoice.Next(0, 4);//giving me a option between 0 and 3 to use
            return computerDicePicked;// return said values so it knows which dice to roll
     
        }
        public void CPURollOddEven()//keep track of whether the roll was even or odd by deviding it by 2 to see if ther is a remainder
        {
            if (computerScore % 2 == 0)//this is taking the computers score and deviding it by 2 to see if the raminder is zero since all even numbers are devisible by zero
            {
                computerEvenRolls++;//if it is then increse the odd roll by one
            }
            else
            {
                computerOddRolls++;//otherwise its odd and increase that stat to call at the end
            }
        }
        public int CPUDiceHas()
        {
            if (computerDicePicked == 0 && sixComputerSidedDiceAvalible) //if the computers input was a one then and they havent used this dice then proced
            {
                Console.WriteLine("-------------------------------------------");
                int randomD6Roll = computerDiceList[0].RandomDiceRoll(); //rolls dice
                sixComputerSidedDiceAvalible = false; // sets bool to false so they can no longer use it
                Console.WriteLine($"CPU dumped {computerDiceList[0].previousResults} bullets into there 6 round mag."); //saying what they rolled 
                computerScore = computerDiceList[0].previousResults;// adding said roll to their score
                computerScoreTotal += computerScore;
                CPURollOddEven();
                AverageComputerRolls();
            }

            else if (computerDicePicked == 1 && eightComputerSidedDiceAvalible)
            {
                Console.WriteLine("-------------------------------------------");
                int randomD8Roll = computerDiceList[1].RandomDiceRoll();
                eightComputerSidedDiceAvalible = false;
                Console.WriteLine($"CPU CPU dumped {computerDiceList[1].previousResults} bullets into there 8 round mag.");
                computerScore = computerDiceList[1].previousResults;
                computerScoreTotal += computerScore;
                CPURollOddEven();
                AverageComputerRolls();
            }

            else if (computerDicePicked == 2 && twelveComputerSidedDiceAvalible)
            {
                Console.WriteLine("-------------------------------------------");
                int randomD12Roll = computerDiceList[2].RandomDiceRoll();
                twelveComputerSidedDiceAvalible = false;
                Console.WriteLine($"CPU dumped {computerDiceList[2].previousResults} bullets into there 12 round mag");
                computerScore = computerDiceList[2].previousResults;
                computerScoreTotal += computerScore;
                CPURollOddEven();
                AverageComputerRolls();
            }

            else if (computerDicePicked == 3 && twentyComputerSidedDiceAvalible)
            {
                Console.WriteLine("-------------------------------------------");
                int randomD20Roll = computerDiceList[3].RandomDiceRoll();
                twentyComputerSidedDiceAvalible = false;
                Console.WriteLine($"CPU dumped {computerDiceList[3].previousResults} bullets into there 20 round mag");
                computerScore = computerDiceList[3].previousResults;
                computerScoreTotal += computerScore;
                CPURollOddEven();
                AverageComputerRolls();
            }
            else
            {
                DiceReturn();
            }
            return computerScore;
        }
       


        bool sixComputerSidedDiceAvalible = true; //set up ma bool so when there arent any dice left i can turn it to false as it isnt avalible
        bool eightComputerSidedDiceAvalible = true;
        bool twelveComputerSidedDiceAvalible = true;
        bool twentyComputerSidedDiceAvalible = true; // dice availability
    }
}