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
        public int AverageComputerRolls()
        {
            computerAverageResult = computerScoreTotal / 4;
            return computerAverageResult;
        }
        public void DiceReturn()
        {
            CPUDiceSelect();
            CPUDiceHas();
        }
        internal int CPUDiceSelect()
        {
            Random computerChoice = new Random();
            computerDicePicked = computerChoice.Next(0, 4);
            return computerDicePicked;
     
        }
        public void CPURollOddEven()
        {
            if (computerScore % 2 == 0)
            {
                computerEvenRolls++;
            }
            else
            {
                computerOddRolls++;
            }
        }
        public int CPUDiceHas()
        {
            //setting up a variable for the players input

            if (computerDicePicked == 0 && sixComputerSidedDiceAvalible) //if mthe players input was a one then and they havent used this dice then proced
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