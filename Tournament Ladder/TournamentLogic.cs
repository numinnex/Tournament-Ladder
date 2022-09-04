using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Tournament_Ladder.Interfaces;
using Tournament_Ladder.Models;

namespace Tournament_Ladder
{
    public static class TournamentLogic
    {
        public static List<ITeam> Teams = new();
        public static List<int> Rounds = new();
        public static List<MatchupModel> Matchups = new();

        public static void InitializeTournament(Tree ladder)
        {

            ladder.PostOrder(ladder.Root, SetupRounds);
            ladder.PostOrder(ladder.Root, SetupMatchups);
            CollectTeams(Matchups);

            CollectRounds(ladder);
        }

        public static void UpdateMatchups(Tree ladder)
        {
            Matchups.Clear();
            ladder.PostOrder(ladder.Root, AdvanceTeams);
            ladder.PostOrder(ladder.Root, SetupMatchups);
            Teams.Clear();
            CollectTeams(Matchups);

        }


        private static void AdvanceTeams(Node root)
        {
            if (root == null)
                return;

            if (root.Data.Completed == false && root.Data.Round > 1)
            {
                if (root.Left.Data.Winner != null && !root.Left.Data.Completed)
                {

                    root.Data.TeamsCompeting.Add(root.Left.Data.Winner);
                    root.Left.Data.Completed = true;

                }
                else if (root.Right.Data.Winner != null && !root.Right.Data.Completed)
                {


                    root.Data.TeamsCompeting.Add(root.Right.Data.Winner);
                    root.Right.Data.Completed = true;

                }

                else
                    return;
            }
            else
                return;
        }


        private static void CollectTeams(List<MatchupModel> mu)
        {

            foreach (MatchupModel m in mu)
            {

                if (!m.Completed)
                {
                    foreach (var t in m.TeamsCompeting)
                    {
                        Teams.Add(t);
                    }
                }

            }
        }


        private static void SetupMatchups(Node root)
        {
            if (!root.Data.Completed)
                Matchups.Add(root.Data);

        }



        private static void CollectRounds(Tree ladder)
        {
            int maxRound = ladder.Height();
            for (int i = 1; i <= maxRound; i++)
                Rounds.Add(i);

        }

        private static void SetupRounds(Node root)
        {
            root.Data.Round = root.Depth();
        }
    }
}
