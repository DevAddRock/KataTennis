using NUnit.Framework;
using System;
using System.Collections.Generic;
using TennisGame;

namespace Tests
{
    public class Tests
    {
        private PointTennis pointTennis;

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

                AddScores((int)row[0], (int)row[1]);

                Assert.AreEqual(row[2], pointTennis.MatcheScores());
            }
        }

        public void AddScores(int player1Score, int player2Score)
        {
            for (int i = 0; i < player1Score; i++)
            {
                pointTennis.SetSocreToPlayer1();
            }
            for (int i = 0; i < player2Score; i++)
            {
                pointTennis.SetSocreToPlayer2();
            }
        }

    }
}