using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Bowling
{
    public class Rolling
    {

        public static List<int> RollAll()
        {
            List<int> score = new List<int>();

            //loops 10 times and gives a number
            for (int i = 0; i < 10; i++)
            {
                int scorePlaceholder = IndividualRoll();
                score.Add(scorePlaceholder);
                //check to see if next roll is needed
                if (scorePlaceholder == 10)
                {
                    score.Add(0);
                }
                else
                {
                    score.Add(SecondRoll(scorePlaceholder));

                }

            }
            return score;
        }
        //First roll of a frame
        public static int IndividualRoll()
        {
            Random r = new Random();
            int roll = r.Next(0, 10);
            return roll;

        }
        //Second roll of frame
        public static int SecondRoll(int firstRoll)
        {
            Random rT = new Random();
            int remainingPins = 11 - firstRoll;
            int rollTwo;
            rollTwo = rT.Next(0, remainingPins);
            return rollTwo;
        }
        //checks to see if bonus rolls should be applied at thex end and rolls them if necessary
        public static List<int> BonusScoresAdded(List<int> preBonusScores)
        {
            List<int> scores = preBonusScores;
            if (scores[18] == 10)
            {
                int bonusPlaceholder = IndividualRoll();
                scores.Add(bonusPlaceholder);

                if (bonusPlaceholder == 10)
                {
                    scores.Add(IndividualRoll());
                }
                else
                {
                    scores.Add(SecondRoll(bonusPlaceholder));
                }
            }
            else if (scores[18] + scores[19] == 10)
            {
                scores.Add(IndividualRoll());
            }
            return scores;
        }
    }
}
