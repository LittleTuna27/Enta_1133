using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment_1.SCripts
{
    internal class PlayerVSComputer
    {
        PlayerProfile player = new PlayerProfile();
        ComputerProfile CPU = new ComputerProfile();
        

        internal int totalTurns = 4;

        public string username;

        internal bool whoGoFirst = true;

        
        internal bool TurnOrder()
        {
            Random random = new Random();
            if (random.Next(0, 2) == 0)
            {
                Console.WriteLine($"{username} Goes First");
                whoGoFirst = true;
            }
            else
            {
                Console.WriteLine("Computer Goes First");
                whoGoFirst = false;
            }

            return whoGoFirst;
        }
            internal void WhatThatTurnDo()
        {

            if (whoGoFirst == true)
            {

                for (int i = 0; i < totalTurns; i++) //start at zero then check if i is past turns 
                {
                    player.PlayerPickDice();
                    player.PlayerDiceHas();
                    CPU.CPUDiceSelect();
                    CPU.CPUDiceHas();
                    ScoreRound();

                }
            }

            else
            {
                for (int i = 0; i < totalTurns; i++) //start at zero then check if i is past turns 
                {
                    CPU.CPUDiceSelect();
                    CPU.CPUDiceHas();
                    player.PlayerPickDice();
                    player.PlayerDiceHas();
                    ScoreRound();

                }
            }
            ScoreCompare();
            PlayAgain();
        }

        internal void ScoreRound() //comparing the players score to the computers to see who won
        {
            if (player.playerScore > CPU.computerScore) //if the players score is greater then the computers display win message
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"The computer shot {CPU.computerScore} rounds");//display of the computer round score
                Console.WriteLine($"While you shot {player.playerScore} rounds");//display of the players round score
                Console.WriteLine("so you Win!!!");
                player.playerResult++;
                Console.WriteLine("-------------------------------------------");
            }
            else if (player.playerScore == CPU.computerScore) //if the players score is equal to the computers display tie message
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"The computer shot {CPU.computerScore} rounds");//display of the computer round score
                Console.WriteLine($"While you shot {player.playerScore} rounds");//display of the players round score
                Console.WriteLine("so you Tie");
                Console.WriteLine("-------------------------------------------");
            }
            else if (player.playerScore < CPU.computerScore)//if the players score is less then the computers display lose message
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"The computer shot {CPU.computerScore} rounds");//display of the computer round score
                Console.WriteLine($"While you shot {player.playerScore} rounds");//display of the players round score
                Console.WriteLine("so you LOSE OH NOOOOOOOO");
                Console.WriteLine("Computer earned one point");
                CPU.computerResult++;
                Console.WriteLine("-------------------------------------------");
            }
        }
        internal void ScoreCompare() //comparing the players score to the computers to see who won
        {
            if (player.playerResult > CPU.computerResult) //if the players score is greater then the computers display win message
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"The computer had won {CPU.computerResult} turns");//display of the computer rounds won
                Console.WriteLine($"The computer had a {CPU.computerEvenRolls} even rolls ");//display of the computer evens
                Console.WriteLine($"The computer had a {CPU.computerOddRolls} odd rolls ");//display of the computer odds
                Console.WriteLine($"rolling a total of {CPU.computerScoreTotal} points ");//display of the computers total score
                Console.WriteLine($"The Computer fired on average {CPU.computerAverageResult} rounds");//display of the players average score
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"You have won {player.playerResult} rounds ");//display of the computer rounds won
                Console.WriteLine($"You had {player.playerEvenRolls} even rolls ");//display of the players total even rolls
                Console.WriteLine($"You had {player.playerOddRolls} odd rolls ");//display of the players total odd rolls
                Console.WriteLine($"You had fired a total of {player.playerScoreTotal} rounds");//display of the players total score
                Console.WriteLine($"You had fired on average of {player.playerAverageResult} rounds");//display of the players average score
                Console.WriteLine("so you Win!!!");
                Console.WriteLine($"Congrats {username}");
                Console.WriteLine("---------------------------------------------------");
            }
            else if (player.playerResult == CPU.computerResult) //if the players score is equal to the computers display tie message
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"The computer had won {CPU.computerResult} turns");//display of the computer rounds won
                Console.WriteLine($"The computer had a {CPU.computerEvenRolls} even rolls ");//display of the computer evens
                Console.WriteLine($"The computer had a {CPU.computerOddRolls} odd rolls ");//display of the computer odds
                Console.WriteLine($"rolling a total of {CPU.computerScoreTotal} points ");//display of the computers total score
                Console.WriteLine($"The Computer fired on average {CPU.computerAverageResult} rounds");//display of the players average score
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"You have won {player.playerResult} rounds ");//display of the computer rounds won
                Console.WriteLine($"You had {player.playerEvenRolls} even rolls ");//display of the players total even rolls
                Console.WriteLine($"You had {player.playerOddRolls} odd rolls ");//display of the players total odd rolls
                Console.WriteLine($"You had fired a total of {player.playerScoreTotal} rounds");//display of the playerscore
                Console.WriteLine($"You had fired on average of {player.playerAverageResult} rounds");//display of the players average score
                Console.WriteLine("so you Tie");
                Console.WriteLine($"Cold have been worse {username}");
                Console.WriteLine("---------------------------------------------------");
            }
            else if (player.playerResult < CPU.computerResult)//if the players score is less then the computers display lose message
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"The computer had won {CPU.computerResult} turns");//display of the computer rounds won
                Console.WriteLine($"The computer had a {CPU.computerEvenRolls} even rolls ");//display of the computer evens
                Console.WriteLine($"The computer had a {CPU.computerOddRolls} odd rolls ");//display of the computer odds
                Console.WriteLine($"rolling a total of {CPU.computerScoreTotal} points ");//display of the computers total score
                Console.WriteLine($"The Computer fired on average {CPU.computerAverageResult} rounds");//display of the players average score
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"You have won {player.playerResult} rounds ");//display of the computer rounds won
                Console.WriteLine($"You had {player.playerEvenRolls} even rolls ");//display of the players total even rolls
                Console.WriteLine($"You had {player.playerOddRolls} odd rolls ");//display of the players total odd rolls
                Console.WriteLine($"You had fired a total of {player.playerScoreTotal} rounds");//display of the playerscore
                Console.WriteLine($"You had fired on average of {player.playerAverageResult} rounds");//display of the players average score
                Console.WriteLine("so you LOSE OH NOOOOOOOO");
                Console.WriteLine($"Sorry {username}");
                Console.WriteLine("---------------------------------------------------");
            }
        }
        internal void PlayAgain()
        {
            GameManager gameManager = new GameManager(); //making a new game manager to start loop again if needed
            Console.WriteLine("You Wanna Go Again"); //asking player to play again
            Console.WriteLine("Yes or No");
            string Replay; //a string to take hold their reply
            Replay = Console.ReadLine(); //allowing the player to input


            if (Replay == "Yes" || Replay == "yes" || Replay == "y" || Replay == "Y" || Replay == "1") //if yes then reset all variables to there start
            {
                player.playerScore = 0; //resetting my integers back to starting state if the player wants to start a fresh game
                player.playerResult = 0;
                player.playerEvenRolls = 0;
                player.playerOddRolls = 0;

                bool sixSidedDiceAvalible = true; //resetting my bools back to starting state
                bool eightSidedDiceAvalible = true;
                bool twelveSidedDiceAvalible = true;
                bool twentySidedDiceAvalible = true;

                CPU.computerResult = 0; //resetting my integers back to starting state
                CPU.computerScore = 0;
                CPU.computerEvenRolls = 0;
                CPU.computerOddRolls = 0;

                bool sixComputerSidedDiceAvalible = true; //resetting my bools back to starting state
                bool eightComputerSidedDiceAvalible = true;
                bool twelveComputerSidedDiceAvalible = true;
                bool twentyComputerSidedDiceAvalible = true;

                gameManager.Intro();

       
            }
            else //ends game with a tank you
            {
                gameManager.roundContinue = false; //ends game with a tank you
                Console.WriteLine("We understand your and thank you for your time partner"); //thank you message
                Environment.Exit(0);//closses game
            }
        }
    }
}
