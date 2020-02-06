using NUnit.Framework;
using System;
using System.Collections.Generic;
using TennisGame;

namespace Tests
{
    public class Tests
    {
        private PointTennis pointTennis;
        private SetTennis setTennis;
        private Tie_BreakTennis tie_BreakTennis;

        private List<List<Object>> TablePointScores()
        {
            return new List<List<Object>>()
                {
                    new List<Object>() {0, 0, "0 - 0"},
                    new List<Object>() {0, 1, "0 - 15"},
                    new List<Object>() {1, 0, "15 - 0"},
                    new List<Object>() {1, 1, "15 - 15"},
                    new List<Object>() {0, 2, "0 - 30"},
                    new List<Object>() {1, 2, "15 - 30"},
                    new List<Object>() {2, 2, "30 - 30"},
                    new List<Object>() {2, 0, "30 - 0"},
                    new List<Object>() {2, 1, "30 - 15"},
                    new List<Object>() {0, 3, "0 - 40"},
                    new List<Object>() {1, 3, "15 - 40"},
                    new List<Object>() {2, 3, "30 - 40"},
                    new List<Object>() {3, 3, "DEUCE"},
                    new List<Object>() {3, 0, "40 - 0"},
                    new List<Object>() {3, 1, "40 - 15"},
                    new List<Object>() {3, 2, "40 - 30"},
                    new List<Object>() {0, 4, "Player2 win"},
                    new List<Object>() {4, 4, "DEUCE"},
                    new List<Object>() {4, 0, "Player1 win"},
                    new List<Object>() {4, 3, "ADV Player1"},
                    new List<Object>() {14, 15, "ADV Player2" }

                };
        }

        private List<List<Object>> TableSetScores()
        {
            return new List<List<Object>>()
                {
                    new List<Object>() {0 , 0, "0 - 0" },
                    new List<Object>() {1 , 0, "1 - 0" },
                    new List<Object>() {1 , 1, "1 - 1" },
                    new List<Object>() {1 , 2, "1 - 2" },
                    new List<Object>() {2 , 3, "2 - 3" },
                    new List<Object>() {2 , 4, "2 - 4" },
                    new List<Object>() {2 , 5, "2 - 5" },
                    new List<Object>() {2 , 6, "Player2 win the match" },

                    new List<Object>() {6 , 1, "Player1 win the match" },

                    new List<Object>() {5 , 7, "Player2 win the match" },

                    new List<object>() { 7, 5, "Player1 win the match" },

                    new List<Object>() {6 , 6, "Tie Break score" },

                };
        }

        private List<List<Object>> TableTieBreakScore()
        {
            return new List<List<Object>>()
                {
                    new List<Object>() {1, 0,"1 - 0" },
                    new List<Object>() {1, 1,"1 - 1" },
                    new List<Object>() {2, 1,"2 - 1" },
                    new List<Object>() {3, 2,"3 - 2" },
                    new List<Object>() {4, 2,"4 - 2" },
                    new List<Object>() {5, 2,"5 - 2" },
                    new List<Object>() {6, 2,"6 - 2" },
                    new List<Object>() {7, 2,"Player1 win the match" },

                    new List<Object>() {7, 6,"7 - 6" },
                    new List<Object>() {7, 7,"7 - 7" },

                    new List<Object>() {10, 10,"10 - 10" },

                    new List<Object>() {14, 12,"Player1 win the match" },
                    new List<Object>() {12, 14,"Player2 win the match" },

                };
        }

        /// <summary>
        /// Test the methods of class PointTennis
        /// </summary>
        [Test]
        public void TestPointTennis()
        {
            var table = TablePointScores();

            foreach (var row in table)
            {
                pointTennis = new PointTennis();

                AddScores((int)row[0], (int)row[1], pointTennis);

                Assert.AreEqual(row[2], pointTennis.MatcheScores());
            }
        }

        /// <summary>
        /// Test the methods of class SetTennis
        /// </summary>
        [Test]
        public void TestSetTennis()
        {
            var table = TableSetScores();

            foreach (var row in table)
            {
                setTennis = new SetTennis();
                AddScores((int)row[0], (int)row[1], setTennis);

                Assert.AreEqual(row[2], setTennis.MatchScore());
            }
        }

        /// <summary>
        /// Test the methods of class Tie_BreakTennis
        /// </summary>
        [Test]
        public void TestTie_BreakTennis()
        {
            var table = TableTieBreakScore();

            foreach (var row in table)
            {
                tie_BreakTennis = new Tie_BreakTennis();
                AddScores((int)row[0], (int)row[1], tie_BreakTennis);

                Assert.AreEqual(row[2], tie_BreakTennis.MatchScore());
            }
        }

        public void AddScores(int player1Score, int player2Score, TennisBase tennisBase)
        {
            for (int i = 0; i < player1Score; i++)
            {
                tennisBase.SetSocreToPlayer1();
            }
            for (int i = 0; i < player2Score; i++)
            {
                tennisBase.SetSocreToPlayer2();
            }
        }

    }
}