    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGame
{
    public class PointTennis
    {
        public int ScorePlayer1 = 0, ScorePlayer2 = 0;
        private const int score_40 = 3;
        /// <summary>
        /// Get the result of socre
        /// </summary>
        /// <returns></returns>
        public string MatcheScores()
        {
            if (IsWin())
            {
                return GetPlayer() + " win";
            }
            if (IsADV())
                return "ADV " + GetPlayer();
            if (IsDeuce())
                return "DEUCE";

            return string.Format("{0} - {1}", Score(ScorePlayer1), Score(ScorePlayer2));
        }

        /// <summary>
        /// Return true if we have a winner
        /// </summary>
        /// <returns></returns>
        public bool IsWin()
        {
            return (ScorePlayer1 >= ScorePlayer2 + 2 && ScorePlayer1 > 3)
                || (ScorePlayer2 >= ScorePlayer1 + 2 && ScorePlayer2 > 3);
        }

        /// <summary>
        /// Get the player that got more points
        /// </summary>
        /// <returns></returns>
        public string GetPlayer()
        {
            return ScorePlayer1 > ScorePlayer2 ? "Player1" : "Player2";
        }

        /// <summary>
        /// Return true if we have a ADV
        /// </summary>
        /// <returns></returns>
        private bool IsADV()
        {
            return (ScorePlayer2 == ScorePlayer1 + 1 && ScorePlayer2 > 3)
                || (ScorePlayer1 == ScorePlayer2 + 1 && ScorePlayer1 > 3);
        }

        /// <summary>
        /// Return true if we have a DEUCE
        /// </summary>
        /// <returns></returns>
        private bool IsDeuce()
        {
            return ScorePlayer1 == ScorePlayer2 && ScorePlayer1 > 2;
        }

        /// <summary>
        /// Score increment for player 1
        /// </summary>
        /// <returns></returns>
        public int SetSocreToPlayer1()
        {
            return ++ScorePlayer1;
        }
        /// <summary>
        /// Score increment for player 1
        /// </summary>
        /// <returns></returns>
        public int SetSocreToPlayer2()
        {
            return ++ScorePlayer2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        private static string Score(int score)
        {
            if (score == 1) return "15";
            if (score == 2) return "30";
            if (score == 3) return "40";

            return "0";
        }
    }
}
