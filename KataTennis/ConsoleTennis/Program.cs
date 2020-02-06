using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisGame;

namespace ConsoleTennis
{
    class Program
    {
        private PointTennis pointTennis;
        private SetTennis setTennis;
        private Tie_BreakTennis tie_BreakTennis;
        private TennisBase tennisBase;

        static void Main(string[] args)
        {
            var p = new Program();

            string point = "";
            p.setTennis = new SetTennis();
            p.tennisBase = p.setTennis;

            p.pointTennis = new PointTennis();
            while (!p.tennisBase.IsWin())
            {

                while (point != "1" && point != "2")
                {
                    Console.Write("Who won the point ? Player (1/2) : ");
                    point = Console.ReadLine();

                    if (point != "1" && point != "2")
                    {
                        Console.WriteLine("You must enter 1 or 2");
                    }
                }


                if (!p.setTennis.isTieBreak)
                {
                    p.AddScores(int.Parse(point), p.pointTennis);


                    if (p.pointTennis.IsWin())
                    {
                        if (p.pointTennis.GetPlayer().Equals("Player1"))
                            p.setTennis.SetSocreToPlayer1();
                        else
                            p.setTennis.SetSocreToPlayer2();

                        p.pointTennis.ScorePlayer1 = 0;
                        p.pointTennis.ScorePlayer2 = 0;
                    }

                    Console.WriteLine("p1- p2|");
                    Console.WriteLine(p.setTennis.MatchScore() + " | " + p.pointTennis.MatcheScores());

                }
                else
                {
                    if (Singleton.Instance(p.tie_BreakTennis) == true)
                        p.tie_BreakTennis = new Tie_BreakTennis();

                    p.tennisBase = p.tie_BreakTennis;
                    p.AddScores(int.Parse(point), p.tennisBase);

                    //Console.WriteLine("Tie Break score");
                    Console.WriteLine("p1- p2|");
                    Console.WriteLine(p.tie_BreakTennis.MatchScore());
                }
                point = "";
            }

            Console.ReadKey();
        }

        public void AddScores(int point, TennisBase tennis)
        {
            if (point == 1)
                tennis.SetSocreToPlayer1();
            else if (point == 2)
                tennis.SetSocreToPlayer2();
        }
    }
}
