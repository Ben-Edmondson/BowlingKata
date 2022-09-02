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

                if (score[scoreOne] == 10)
                {
                    if(scoreOne == 18)
                    {
                        finalScore = finalScore + (score[18] + (score[20] + score[21]));
                    }
                    else
                    {
                        finalScore = finalScore + (score[scoreOne] + (score[scoreTwo + 1] + score[scoreTwo + 3]));
                    }
                }
                else
                {
                    if (score[scoreOne] + score[scoreTwo] < 10)
                    {
                        finalScore = finalScore + score[scoreOne] + score[scoreTwo];
                    }
                    else
                    {
                        finalScore = finalScore + ((score[scoreOne] + score[scoreTwo]) + score[scoreTwo + 1]);
                    }
                }
               
                scoreOne = scoreOne + 2;
                scoreTwo = scoreTwo + 2;
            }
               return finalScore;
        }

        //Writes the scores to the screen
        public static List<string> ScoreBoard(List<int> finalScores)
        { 
            List<int> scores = finalScores;
            List<String> scoreBoard = new List<string>();
            int scoreOne = 0;
            int scoreTwo = 1;
            for (int i = 0; i < 10; i++)
            {
                if (scores[scoreOne] == 10)
                {
                    scoreBoard.Add("X");
                }
                else if (scores[scoreOne] + scores[scoreTwo] == 10)
                {
                    scoreBoard.Add(scores[scoreOne].ToString() + "/");
                }
                else
                {
                    scoreBoard.Add(scores[scoreOne] + "-" + scores[scoreTwo]);
                }
                scoreOne = scoreOne + 2;
                scoreTwo = scoreTwo + 2;
            }
            return scoreBoard;
        }
    }
}
