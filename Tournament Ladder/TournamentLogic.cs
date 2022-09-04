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
        public static List<TeamModel> Teams = new();
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
            //        Teams.Clear();
            //        CollectTeams(Matchups);

        }

     


        private static void AdvanceTeams (Node root)
          {
            if (root == null)
                return;

            if (root.Data.Completed == false && root.Left != null && root.Right != null)
            {
                if (root.Left.Data.Winner != null && !root.Left.Data.Completed)
                {
                   
                    root.Data.TeamsCompeting.Add(root.Left.Data.Winner);
                    root.Left.Data.Completed = true;
                    //if (root.Data.TeamsCompeting.Count() == 2)
                    //root.Data.Active = true;

                }
                else if (root.Right.Data.Winner != null && !root.Right.Data.Completed)
                {
                   
                    
                    root.Data.TeamsCompeting.Add(root.Right.Data.Winner);
                    root.Right.Data.Completed = true;
                    //if (root.Data.TeamsCompeting.Count() == 2)
                    // root.Data.Active = true;

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
                
                    Teams.Add(m.Winner);
                               
                }
            }


            private static void SetupMatchups(Node root)
            {
                if(!root.Data.Completed)
                     Matchups.Add(root.Data);

            }

    
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
