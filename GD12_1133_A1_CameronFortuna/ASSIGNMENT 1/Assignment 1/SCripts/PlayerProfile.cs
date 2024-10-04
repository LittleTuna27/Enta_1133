using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_1.SCripts.DiceRoller;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment_1.SCripts
{
    public class PlayerProfile
    {
        public int playerResult = 0;
        internal int playerScore = 0;
        internal int playerScoreTotal = 0;
        internal int playerPickDice = 0;
        internal int playerEvenRolls = 0;
        internal int playerOddRolls = 0;
        internal int playerAverageResult = 0;

        bool sixSidedDiceAvalible = true; 
        bool eightSidedDiceAvalible = true;
        bool twelveSidedDiceAvalible = true;
        bool twentySidedDiceAvalible = true;

        internal string input;

        // Player's own dice set

        List<DiceRollerV1> playerDiceList = new List<DiceRollerV1> 
        {

            new DiceRollerV1(6),
            new DiceRollerV1(8),
            new DiceRollerV1(12),
            new DiceRollerV1(20),

         };
        public void NoDice()
        {
            PlayerPickDice();
            PlayerDiceHas();        
        }
        public int PlayerPickDice()
        { 
            if (sixSidedDiceAvalible)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine(@"      __,_____
     / __.==--""
    /#(-'           6rounds
    `-'");
            }
            if (eightSidedDiceAvalible)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine(@"      __,_____
     / __.==--""
    /#(-'           8rounds
    `-'");
            }
            if (twelveSidedDiceAvalible)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine(@"      __,_____
     / __.==--""
    /#(-'           12rounds
    `-'");
                
            }
            if (twentySidedDiceAvalible)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine(@"      __,_____
     / __.==--""
    /#(-'           20rounds
    `-'");
            }
            Console.WriteLine("Select a mag to use (1: 6-rounds, 2: 8-rounds, 3: 12-rounds, 4: 20-rounds):"); //display explaining all the options to all the dice options
            input = Console.ReadLine(); //player input
            return playerPickDice;
            
        }
        public int AveragePlayerRolls()
        {
            playerAverageResult = playerScoreTotal / 4;
            return playerAverageResult;
        }
        public void RollOddEven()
        {
            if (playerScore % 2 == 0)
            {
                playerEvenRolls++;
            }
            else
             {
                playerOddRolls++;
             }
        }
        public void PlayerDiceHas()
        {

            // checks to see the players input and then what that input was 

            if (int.TryParse(input, out playerPickDice))
            {
                if (playerPickDice == 1 && sixSidedDiceAvalible) //if mthe players input was a one then and they havent used this dice then proced
                {
                    Console.WriteLine("-------------------------------------------");
                    int randomD6Roll = playerDiceList[0].RandomDiceRoll(); //rolls dice
                    sixSidedDiceAvalible = false; // sets bool to false so they can no longer use it
                    Console.WriteLine($"You got {playerDiceList[0].previousResults} bullets into there 6 round mag."); //saying what they rolled 
                    playerScore = playerDiceList[0].previousResults;// adding said roll to their score
                    playerScoreTotal += playerScore; //adding said round score to their total
                    RollOddEven();//check if roll was even or odd then add to said total
                    AveragePlayerRolls();//taking the total rolls and deviding it by the rounds
                }

                else if (playerPickDice == 2 && eightSidedDiceAvalible)
                {
                    Console.WriteLine("-------------------------------------------");
                    int randomD8Roll = playerDiceList[1].RandomDiceRoll();
                    eightSidedDiceAvalible = false;
                    Console.WriteLine($"You got {playerDiceList[1].previousResults} bullets into there 8 round mag.");
                    playerScore = playerDiceList[1].previousResults;
                    playerScoreTotal += playerScore;
                    RollOddEven();
                    AveragePlayerRolls();
                }

                else if (playerPickDice == 3 && twelveSidedDiceAvalible)
                {
                    Console.WriteLine("-------------------------------------------");
                    int randomD12Roll = playerDiceList[2].RandomDiceRoll();
                    twelveSidedDiceAvalible = false;
                    Console.WriteLine($"You got {playerDiceList[2].previousResults} bullets into there 12 round mag.");
                    playerScore = playerDiceList[2].previousResults;
                    playerScoreTotal += playerScore;
                    RollOddEven();
                    AveragePlayerRolls();
                }

                else if (playerPickDice == 4 && twentySidedDiceAvalible)
                {
                    Console.WriteLine("-------------------------------------------");
                    int randomD20Roll = playerDiceList[3].RandomDiceRoll();
                    twentySidedDiceAvalible = false;
                    Console.WriteLine($"You got {playerDiceList[3].previousResults}bullets into there 20 round mag.");
                    playerScore = playerDiceList[3].previousResults;
                    playerScoreTotal += playerScore;
                    RollOddEven();
                    AveragePlayerRolls();
                }
                else
                {
                    Console.WriteLine("You've already used this mag"); //any other input then these 4 numbers is invalid
                    NoDice();
                    return;

                }
            }
            else
            {
                Console.WriteLine("You've already used this mag"); //any other input then these 4 numbers is invalid
                NoDice();
                return;

            }
        }
    }
}
