using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Tournament_Ladder.Models;

namespace Tournament_Ladder
{
    public static class TournamentLogic
    {
       // public static List<TeamModel> Teams = new();
        public static List<int> Rounds = new();
        public static List<MatchupModel> Matchups = new();
        //private static int matchupId = 1;

        /// <summary>
        /// Initializes the tournament
        /// </summary>
        /// <param name="ladder"></param>
        public static void InitializeTournament(Tree ladder)
        {

            ladder.PostOrder(ladder.Root, SetupRounds);
            ladder.PostOrder(ladder.Root, SetupMatchups);
            //CollectTeams(Matchups);

            CollectRounds(ladder);
        }
        //    /// <summary>
        //    /// Updates the matchup when a team scores victory
        //    /// </summary>
        //    /// <param name="ladder"></param>
            public static void UpdateMatchups(Tree ladder)
            {
        //        Matchups.Clear();
        //        ladder.PostOrder(ladder.Root, MarkLosers);
        //        ladder.PostOrder(ladder.Root, AdvanceTeams);
        //        ladder.PostOrder(ladder.Root, UpdateMatchup);
        //        Teams.Clear();
        //        CollectTeams(Matchups);

            }
        //    /// <summary>
        //    /// Marks the losers in a matchup (redundant but can be useful when implementing Saving/Loading functionality)
        //    /// </summary>
        //    /// <param name="root"></param>
            private static void MarkLosers(Node root)
            {
        //        if (root.Data.Id == 0)
        //            if (root.Left.Data.Winner == true)
        //                root.Right.Data.Winner = false;
        //            else if (root.Right.Data.Winner == true)
        //                root.Left.Data.Winner = false;
            }

        //    /// <summary>
        //    /// Advances the teams on the Binary Tree (Tournament Ladder)
        //    /// </summary>
        //    /// <param name="root"></param>
            private static void AdvanceTeams (Node root)
            {
        //            if (root == null)
        //                return;

        //            if (root.Data.Id == 0)
        //            {
        //                if (root.Left.Data.Winner == true)
        //                {
        //                    Node tmp = new();
        //                    tmp.Data = new();
        //                    tmp.Data.MatchupId = root.Data.MatchupId;
        //                    root.Data = root.Left.Data;
        //                    root.Data.MatchupId = tmp.Data.MatchupId;
        //                    root.Data.Winner = null;
        //                    root.Data.Round++;
        //                    root.Left = null;
        //                    root.Right = null;

        //                }
        //                else if (root.Right.Data.Winner == true)
        //                {
        //                    Node tmp = new();
        //                    tmp.Data = new();
        //                    tmp.Data.MatchupId = root.Data.MatchupId;
        //                    root.Data = root.Right.Data;
        //                    root.Data.MatchupId = tmp.Data.MatchupId;
        //                    root.Data.Winner = null;
        //                    root.Data.Round++;
        //                    root.Left = null;
        //                    root.Right = null;  
        //                }
        //                else
        //                    return;
        //            }
               }

        //    /// <summary>
        //    /// Collects teams displayed in Teams Listbox in TournamentBrackets Form
        //    /// </summary>
        //    /// <param name="mu"></param>
            private static void CollectTeams(List<MatchupModel> mu)
             {
            //        foreach(MatchupModel m in mu)
            //        {
            //            if (m.TeamsCompeting != null)
            //                foreach (TeamModel team in m.TeamsCompeting)
            //                    if(team.Winner == null || team.Winner == true)
            //                        Teams.Add(team);
            //        }
            //    }

            //    /// <summary>
            //    /// Creates Matchups 
            //    /// </summary>
            //    /// <param name="root"></param>
            }
            private static void SetupMatchups(Node root)
            {
                 Matchups.Add(root.Data);

            }

        //    /// <summary>
        //    /// Updates the Matchups when team advances
        //    /// </summary>
        //    /// <param name="root"></param>
            private static void UpdateMatchup(Node root)
            {
        //        MatchupModel mu = new();
        //        mu.TeamsCompeting = new();

        //        if (root.Data.Id == 0)
        //        {
        //            //mu.Id = root.Data.MatchupId;
        //            if (root.Left != null)
        //            {
        //                mu.Id = root.Left.Data.MatchupId;
        //                mu.TeamsCompeting.Add(root.Left.Data);
        //            }

        //            if (root.Right != null)
        //            {
        //                mu.Id = root.Right.Data.MatchupId;
        //                mu.TeamsCompeting.Add(root.Right.Data);
        //            }

        //            Matchups.Add(mu);
        //        }

            }
        //    /// <summary>
        //    /// Collects the rounds displayed in RoundsDropDown in TournamentBrackets Form
        //    /// </summary>
        //    /// <param name="ladder"></param>
            private static void CollectRounds(Tree ladder)
            {
                int maxRound = ladder.Height();
                for (int i = 1; i <= maxRound; i++)
                    Rounds.Add(i);

            }   
        //    /// <summary>
        //    /// Assigns the round property for each team 
        //    /// </summary>
        //    /// <param name="root"></param>
            private static void SetupRounds(Node root)
            {
                root.Data.Round = root.Depth();
            }
        }
}
