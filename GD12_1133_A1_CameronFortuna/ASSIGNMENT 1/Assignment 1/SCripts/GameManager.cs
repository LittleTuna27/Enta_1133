using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.SCripts
{
    internal class GameManager
    {
        PlayerVSComputer bigTurn = new PlayerVSComputer();

        internal bool roundContinue = true;
       
        public void Intro() //the start of code for the intro
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Hello, World"); //just a simple greeting
            Console.WriteLine("I'm Cameron Fortuna in Enta 1133 GD12"); //just an intoduction of myself 
            Console.WriteLine("Welcome to ");
            Console.WriteLine(@" _____                                                                                         _____ 
( ___ )                                                                                       ( ___ )
 |   |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|   | 
 |   |  /$$        /$$$$$$   /$$$$$$  /$$$$$$$        /$$     /$$ /$$$$$$  /$$   /$$ /$$$$$$$  |   | 
 |   | | $$       /$$__  $$ /$$__  $$| $$__  $$      |  $$   /$$//$$__  $$| $$  | $$| $$__  $$ |   | 
 |   | | $$      | $$  \ $$| $$  \ $$| $$  \ $$       \  $$ /$$/| $$  \ $$| $$  | $$| $$  \ $$ |   | 
 |   | | $$      | $$  | $$| $$$$$$$$| $$  | $$        \  $$$$/ | $$  | $$| $$  | $$| $$$$$$$/ |   | 
 |   | | $$      | $$  | $$| $$__  $$| $$  | $$         \  $$/  | $$  | $$| $$  | $$| $$__  $$ |   | 
 |   | | $$      | $$  | $$| $$  | $$| $$  | $$          | $$   | $$  | $$| $$  | $$| $$  \ $$ |   | 
 |   | | $$$$$$$$|  $$$$$$/| $$  | $$| $$$$$$$/          | $$   |  $$$$$$/|  $$$$$$/| $$  | $$ |   | 
 |   | |________/ \______/ |__/  |__/|_______/           |__/    \______/  \______/ |__/  |__/ |   | 
 |   |                                                                                         |   | 
 |   |                                                                                         |   | 
 |   |                                                                                         |   | 
 |   |         /$$$$$$  /$$   /$$ /$$   /$$       /$$$$$$$   /$$$$$$  /$$$$$$$  /$$     /$$    |   | 
 |   |        /$$__  $$| $$  | $$| $$$ | $$      | $$__  $$ /$$__  $$| $$__  $$|  $$   /$$/    |   | 
 |   |       | $$  \__/| $$  | $$| $$$$| $$      | $$  \ $$| $$  \ $$| $$  \ $$ \  $$ /$$/     |   | 
 |   |       | $$ /$$$$| $$  | $$| $$ $$ $$      | $$$$$$$ | $$$$$$$$| $$$$$$$   \  $$$$/      |   | 
 |   |       | $$|_  $$| $$  | $$| $$  $$$$      | $$__  $$| $$__  $$| $$__  $$   \  $$/       |   | 
 |   |       | $$  \ $$| $$  | $$| $$\  $$$      | $$  \ $$| $$  | $$| $$  \ $$    | $$        |   | 
 |   |       |  $$$$$$/|  $$$$$$/| $$ \  $$      | $$$$$$$/| $$  | $$| $$$$$$$/    | $$        |   | 
 |   |        \______/  \______/ |__/  \__/      |_______/ |__/  |__/|_______/     |__/        |   | 
 |___|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|___| 
(_____)                                                                                       (_____) ");
            Console.WriteLine(@"     (                                 _
   )                               /=>
  (  +____________________/\/\___ / /|
   .''._____________'._____      / /|/\
  : () :              :\ ----\|    \ )
   '..'______________.'0|----|      \
                    0_0/____/        \
                        |----    /----\
                       || -\\ --|      \
                       ||   || ||\      \
                        \\____// '|      \
                                .'/       |
                               .:/        |
                               :/_________|");
            Console.WriteLine("Who Are You???");
            bigTurn.username = Console.ReadLine();
            Console.WriteLine($"Welcome {bigTurn.username}");
            Console.WriteLine("You Will be playing against a computer in which you each pick between 4 magazines to load your gun with");
            Console.WriteLine("But be carefure cause once you use it you lose it");
            Console.WriteLine("You each have a 6-round, 8-round, 12-round, 20-round mags");
            Console.WriteLine("Keep in mind that you if you use a mag the computer still has theirs to use");
            Console.WriteLine("Lets Get loading");
            Console.WriteLine("-------------------------------------------");
            GameLoop();
        }
        public void GameLoop()
         {
            do
            {
                bigTurn.TurnOrder();
                bigTurn.WhatThatTurnDo();
            }
            while (roundContinue == true);
         }

        
        public void Outro() //a simple function to play a thank you for playing
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Thanks for playing my game");
            Console.WriteLine(bigTurn.username); //call their name again
            Console.WriteLine("Goodbye");
            Console.WriteLine("-------------------------------------------");
            Environment.Exit(0);
           
        }
    }
}
