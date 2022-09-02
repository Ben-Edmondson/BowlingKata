using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Scoring
    {
        //tallies scores including bonuses for strikes/spares
        public static int ScoreFinal(List<int> scores)
        {
            List<int> score = scores;

            int scoreOne = 0;
            int scoreTwo = 1;
            int finalScore = 0;
            for (int i = 0; i < 10; i++)
            {
                switch (score[scoreOne])
                {
                    case 10:
                        switch (scoreOne)
                        {
                            case 18:
                                finalScore = finalScore + (score[18] + (score[20] + score[21]));
                                break;
                            default:
                                finalScore = finalScore + (score[scoreOne] + (score[scoreTwo + 1] + score[scoreTwo + 3]));
                                break;
                        }
                        break;
                    default:
                        if (score[scoreOne] + score[scoreTwo] < 10)
                        {
                            finalScore = finalScore + score[scoreOne] + score[scoreTwo];
                        }
                        else
                        {
                            finalScore = finalScore + ((score[scoreOne] + score[scoreTwo]) + score[scoreTwo + 1]);
                        }

                        break;
                }
                scoreOne = scoreOne + 2;
                scoreTwo = scoreTwo + 2;
            }
               return finalScore;
        }

        //Writes the scores to the screen
        public static void ScoreBoard(List<int> finalScores, int finalScore)
        {
            int scoreFinal = finalScore;
            List<int> scoreBoard = finalScores;
            Console.WriteLine("Your final score will now be calculated..");

            int scoreOne = 0;
            int scoreTwo = 1;
            for (int i = 0; i < 10; i++)
            {
                if (scoreBoard[scoreOne] == 10)
                {
                    Console.Write("X");

                }
                else if (scoreBoard[scoreOne] + scoreBoard[scoreTwo] == 10)
                {
                    Console.Write(scoreBoard[scoreOne] + "/");
                }
                else
                {
                    Console.Write(scoreBoard[scoreOne] + "-" + scoreBoard[scoreTwo]);
                }

                Console.Write(" ");
                scoreOne = scoreOne + 2;
                scoreTwo = scoreTwo + 2;
            }
            Console.WriteLine($"Final Score: {finalScore}");
        }
    }
}
