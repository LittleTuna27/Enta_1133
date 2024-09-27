using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_week_3.Scripts_part_2
{
    internal class GameManagerV2  //this is creating the container to hold the code so you can call this script to other scripts
    {
        public int score = 0;

        Player_Vs_Computer computer = new Player_Vs_Computer();
        Player_profile player = new Player_profile();

        DiceRollerV2 sixSidedDice = new DiceRollerV2();// set up a new class for each dice needed
        DiceRollerV2 eightSidedDice = new DiceRollerV2();
        DiceRollerV2 twelveSidedDice = new DiceRollerV2();
        DiceRollerV2 twentySidedDice = new DiceRollerV2();
        internal void DiceSet()
        {
            sixSidedDice.totalSides = 6; // changeing all the classes made
            eightSidedDice.totalSides = 8;
            twelveSidedDice.totalSides = 12;
            twentySidedDice.totalSides = 20;
        }


        bool sixSidedDiceAvalible = true; //set up ma bool so when there arent any dice left i can turn it to false as it isnt avalible
        bool eightSidedDiceAvalible = true;
        bool twelveSidedDiceAvalible = true;
        bool twentySidedDiceAvalible = true;

    
        string nameSave;
        
        public void ProgramStart() //this is at the start execute these things in this order
        {
            DiceSet();
            Intro(); //introduction of me and the game
            ComputerTurn();
            GameLoop(); // main chunck of coding for the game
            ScoreCompare();
            Outro(); //text of saying thanks
        }
       

        
        public void Intro() //the start of code for the intro
        {
                Console.WriteLine("Hello, World"); //just a simple greeting
                Console.WriteLine("I'm Cameron Fortuna in Enta 1133 GD12"); //just an intoduction of myself 
                Console.WriteLine("Who are you");
                nameSave = Console.ReadLine();
        }
        public void ComputerTurn()// a function to change the score depending on the result of the dice roll
        {
            computer.computerScore = 0; //storing computer score
            sixSidedDice.RandomDiceRoll(); //rolling the dice based of of the sides once
            computer.computerScore += sixSidedDice.previousResults;// adding resulting roll to the computers total
                eightSidedDice.RandomDiceRoll();
                computer.computerScore += eightSidedDice.previousResults;
                    twelveSidedDice.RandomDiceRoll();
                    computer.computerScore += twelveSidedDice.previousResults;
                        twentySidedDice.RandomDiceRoll();
                        computer.computerScore += twentySidedDice.previousResults;
        }

        public void DiceSelection()
        {
            Console.WriteLine("Select a die to roll (1: 6-sided, 2: 8-sided, 3: 12-sided, 4: 20-sided):"); //display explaining all the options to all the dice options
            string input = Console.ReadLine(); //player input
            int playerPickDice; //setting up a variable for the players input

            if (int.TryParse(input, out playerPickDice)) // checks to see the players input and then what that input was 

            if (playerPickDice == 1 && sixSidedDiceAvalible) //if mthe players input was a one then and they havent used this dice then proced
             {      
              int randomD6Roll = sixSidedDice.RandomDiceRoll(); //rolls dice
              sixSidedDiceAvalible = false; // sets bool to false so they can no longer use it
                    Console.WriteLine($"You rolled a {sixSidedDice.previousResults} on a 6-sided die."); //saying what they rolled 
                    score += eightSidedDice.previousResults;// adding said roll to their score
              }

            else if (playerPickDice == 2 && eightSidedDiceAvalible)
             {
                int randomD8Roll = eightSidedDice.RandomDiceRoll();
                eightSidedDiceAvalible = false;
                    Console.WriteLine($"You rolled a {eightSidedDice.previousResults} on a 8-sided die.");
                    score += eightSidedDice.previousResults;
             }

            else if (playerPickDice == 3 && twelveSidedDiceAvalible)
             {
                int randomD12Roll = twelveSidedDice.RandomDiceRoll();
                twelveSidedDiceAvalible = false;
                    Console.WriteLine($"You rolled a {twelveSidedDice.previousResults} on a 12-sided die.");
                    score += twelveSidedDice.previousResults;
             }

            else if (playerPickDice == 4 && twentySidedDiceAvalible)
             {
                int randomD20Roll = twentySidedDice.RandomDiceRoll();
                twentySidedDiceAvalible = false;
                    Console.WriteLine($"You rolled a {twelveSidedDice.previousResults} on a 20-sided die.");
                    score += twentySidedDice.previousResults;
             }

            else
             {
                Console.WriteLine("ERROR, Please eneter a valid answer!"); //any other input then these 4 numbers is invalid
                return;
             }
            
        }
    
        public void GameLoop() //the start of the gameplay loop
        {
            Console.WriteLine("Welcome to Die vs Die!");
            DiceSelection(); //calling the function 4 times as that was how many times we wanted them dice to roll
            DiceSelection();
            DiceSelection();
            DiceSelection();
            TurnsLeft(); //then a function to check if they have finished usign all the posibble dice
            DiceSelection();
            TurnsLeft();
            DiceSelection();
            TurnsLeft();
            DiceSelection();
            TurnsLeft();
            DiceSelection();
            TurnsLeft();
            Console.WriteLine("your total roll was " + score); //saying what their final score is at the score
        }

            public void TurnsLeft()
            {
            if (!sixSidedDiceAvalible && !eightSidedDiceAvalible && !twelveSidedDiceAvalible && !twentySidedDiceAvalible) //saying that this function only only happens once all of these bools are false
                {
                    ScoreCompare(); //comparing the players score to the computers to see who won
                    Outro();
                 }

            }

        public void ScoreCompare() //comparing the players score to the computers to see who won
        {
            if (score > computer.computerScore) //if the players score is greater then the computers display win message
            {
                Console.WriteLine("the computer rolled a " + computer.computerScore);
                Console.WriteLine("While you rolled a " + score);
                Console.WriteLine("so you Win!!!");
            }
            else if(score == computer.computerScore) //if the players score is equal to the computers display tie message
            {
                Console.WriteLine("the computer rolled a " + computer.computerScore);
                Console.WriteLine("While you rolled a " + score);
                Console.WriteLine("so you Tie");
              }
            else if (score < computer.computerScore)//if the players score is less then the computers display lose message
            {
                Console.WriteLine("the computer rolled a " + computer.computerScore);
                Console.WriteLine("While you rolled a " + score);
                Console.WriteLine("so you LOSE OH NOOOOOOOO");
            }  
         }

        public void Outro() //a simple function to play a thank you for playing
        {
            Console.WriteLine("Thanks for playing my game");
            Console.WriteLine(nameSave); //call their name again
            Console.WriteLine("Goodbye");
            Environment.Exit(0);
        }
    }
}