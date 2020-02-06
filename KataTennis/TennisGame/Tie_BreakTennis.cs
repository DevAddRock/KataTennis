using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame
{
    public class Tie_BreakTennis : TennisBase
    {
        private const int score_7 = 7;

        /// <summary>
        /// Get the result of socre
        /// </summary>
        /// <returns></returns>
        public string MatchScore()
        {
            if (IsWin())
                return GetPlayer() + " win the match";

            return string.Format("{0} - {1}", ScorePlayer1, ScorePlayer2);
        }

        /// <summary>
        /// Return true if we have a winner
        /// </summary>
        /// <returns></returns>
        public override bool IsWin()
        {
            return (ScorePlayer1 >= score_7 && ScorePlayer1 > ScorePlayer2 + 1)
                || (ScorePlayer2 >= score_7 && ScorePlayer2 > ScorePlayer1 + 1);
        }
    }
}
