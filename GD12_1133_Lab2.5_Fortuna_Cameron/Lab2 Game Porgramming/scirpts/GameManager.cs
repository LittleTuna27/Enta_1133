using Lab2_Game_Porgramming.scirpts.scirpt;
using System; 
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Game_Porgramming.scirpts
{
    internal class GameManager //this is creating the container to hold the code so you can call this script to other scripts
    {
        DiceRoller rolling = new DiceRoller();
        public int score = 0;
        public  void ProgramStart() //this is at the start execute these things in this order
        {
            Intro(); //introduction of me and the game
            GameLoop(); // main chunck of coding for the game
            Outro(); //text of saying thanks

            score = score + rolling.RandomDiceRoll();

           
        }
        public  void Intro() //the start of code for the intro
        {
            Console.WriteLine("Hello, World"); //just a simple greeting
            Console.WriteLine("I'm Cameron Fortuna in Enta 1133 GD12"); //just an intoduction of myself 
        }
        public  void ChangeScore()// a function to change the score depending on the result of the dice roll
        {
            score += rolling.RandomDiceRoll(); // calling for my dice roller function to trigger to give me a random roll then adding it to my score
            Console.WriteLine("You rolled a " + rolling.previousResults); //calling the previous result of the random dice roll to display what they have rolled
         }


        public  void GameLoop() //the start of the gameplay loop
        {
            Console.WriteLine("Welcome to Die vs Die!");
            ChangeScore(); //calling the function 4 times as that was how many times we wanted the dice to roll
            ChangeScore();
            ChangeScore();
            ChangeScore();
            Console.WriteLine("your total roll was " + score); //saying what their final score is at the score
        }
        public  void Outro() //a simple function to play a thank you for playing
        {
            Console.WriteLine("Thanks for playing my game");
            Console.WriteLine("Goodbye");

         }
    }
 } 