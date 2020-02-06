

namespace TennisGame
{
    public abstract class TennisBase
    {
        public int ScorePlayer1 = 0, ScorePlayer2 = 0;

        public TennisBase()
        {
            ScorePlayer1 = 0;
            ScorePlayer2 = 0;
        }
        public abstract bool IsWin();
        /// <summary>
        /// Get the player that got more points
        /// </summary>
        /// <returns></returns>
        public string GetPlayer()
        {
            return ScorePlayer1 > ScorePlayer2 ? "Player1" : "Player2";
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
    }
}
