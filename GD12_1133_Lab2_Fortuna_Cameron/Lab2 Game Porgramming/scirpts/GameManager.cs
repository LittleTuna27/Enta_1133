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
        public  void Programstart() //this is at the start execute these things in this order
        {
            Intro(); //introduction of me and the game
            GameLoop(); // main chunck of coding for the game
            Outro(); //text of saying thanks
        }
        public  void Intro() //the start of code for the intro
        {
            Console.WriteLine("Hello, World"); //just a simple greeting
            Console.WriteLine("IM Cameron Fortuna in Enta 1133 GD12"); //just an intoduction of myself 
        }
        public  void changeScore()// a function to change the score depending on the result of the dice roll
        {
            score += rolling.randomDiceRoll();
            Console.WriteLine("You rolled a " + rolling.previousResults);
         }

        public  void GameLoop() //the start of the gameplay loop
        {
            Console.WriteLine("Welceome to Die vs Die!");
            changeScore();
            changeScore();
            changeScore();
            changeScore();
            Console.WriteLine("your total roll was " + score);
        }
        public  void Outro()
        {
            Console.WriteLine("Thanks for playing my game");
            Console.WriteLine("Goodbye");

         }
    }
 } 