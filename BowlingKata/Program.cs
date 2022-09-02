/*
 * Coding Dojo Bowling Kata
 */



using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu + loop
            bool gameLoop = true;
            string restartGame;
            while (gameLoop == true)
            {
                //Rolls and does scoreboard
                List<int> score = Rolling.BonusScoresAdded(Rolling.RollAll());
                List<string> scoreBoard = Scoring.ScoreBoard(score);
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(scoreBoard[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"Your final score is: {Scoring.ScoreFinal(score)}");
                Console.WriteLine("enter 'xx' to exit game. enter anything else to reset");
                restartGame = Console.ReadLine();
                if (restartGame == "xx")
                {
                    gameLoop = false;
                }
                Console.Clear();
            }
            Console.WriteLine("Thanks for playing!");

        }

        
    }
}