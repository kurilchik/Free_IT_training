using System;
using System.Collections.Generic;
using System.Text;

namespace week_6
{
    class Score
    {
        public static int UserScore;

        public static void MultiplicationScore()
        {
            Score.UserScore = (int)(100 * Math.Pow(2, Game.NumberQuestion));
        }

    }

}
