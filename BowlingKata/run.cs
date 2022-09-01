/*
 * Coding Dojo Bowling Kata
 */



using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Bowling
{

    class Run
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
                Scoring.ScoreBoard(score, Scoring.ScoreFinal(score));
                Console.WriteLine("enter 'xx' to exit game. enter anything else to reset");
                restartGame = Console.ReadLine();
                if (restartGame == "xx")
                {
                    gameLoop = false;
                }

            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}