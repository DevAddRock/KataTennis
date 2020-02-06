

namespace TennisGame
{
    public class SetTennis : TennisBase
    {
        private const int score_6 = 6;
        public bool isTieBreak = false;

        /// <summary>
        /// Get the result of socre
        /// </summary>
        /// <returns></returns>
        public string MatchScore()
        {
            if (IsTieBreak())
            {
                isTieBreak = true;
                return "Tie Break score";
            }

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
            return (ScorePlayer1 == score_6 && ScorePlayer2 < score_6 - 2)
                || (ScorePlayer2 == score_6 && ScorePlayer1 < score_6 - 2)
                || (ScorePlayer1 == score_6 + 1)
                || (ScorePlayer2 == score_6 + 1);
        }

        /// <summary>
        /// return ture if is tie break
        /// </summary>
        /// <returns></returns>
        public bool IsTieBreak()
        {
            return ScorePlayer1 == score_6 && ScorePlayer2 == score_6;
        }
    }
}
