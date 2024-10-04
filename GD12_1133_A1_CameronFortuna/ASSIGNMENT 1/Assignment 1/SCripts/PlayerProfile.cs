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

        List<DiceRollerV1> playerDiceList = new List<DiceRollerV1>  // Player's own dice set list
        {

            new DiceRollerV1(6),//six sidded dice
            new DiceRollerV1(8),//eight sidded dice
            new DiceRollerV1(12),//twelve sided dice
            new DiceRollerV1(20),//twenty sided dice

         };
        public void NoDice()//a function for if they select a unavalible dice or a imput that isnt allowed to reset the choice
        {
            PlayerPickDice();//getting player input on which weapon they want to use
            PlayerDiceHas();        
        }
        public int PlayerPickDice()
        { 
            if (sixSidedDiceAvalible)//estetic to give some visual top my weapons
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
        public int AveragePlayerRolls()//a function to check that after 4 rounds what was roughly the averadge rolls they had by deviding their final score by 4
        {
            playerAverageResult = playerScoreTotal / 4; //a varible thats result id deviding the final score by 4 being the number of rounds i could chang out that number if needed
            return playerAverageResult;//return the result aback to call later
        public void RollOddEven()//keep track of whether the roll was even or odd by deviding it by 2 to see if ther is a remainder
        {
            if (playerScore % 2 == 0)//this is taking the players score and deviding it by 2 to see if the raminder is zero since all even numbers are devisible by zerop
            {
                playerEvenRolls++;//if it is then increse the odd roll by one
            }
            else
             {
                playerOddRolls++;//otherwise its odd and increase that stat to call at the end
             }
        }
        public void PlayerDiceHas()//getting player input on which weapon they want to use
        {
            if (int.TryParse(input, out playerPickDice))//if the players input is a number from their string
            {
                if (playerPickDice == 1 && sixSidedDiceAvalible ||) //if mthe players input was a one then and they havent used this dice then proced
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
                    NoDice();//calls this function too restart sqeunce
                    return;

                }
            }
            else
            {
                Console.WriteLine("You've already used this mag"); //any other input then these 4 numbers is invalid
                NoDice();//calls this function too restart sqeunce
                return;

            }
        }
    }
}
