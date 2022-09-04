using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Ladder.Models;

namespace Tournament_Ladder
{

    public static class LadderCreation
    {
        private static List<TeamModel> RandomizeTeams(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

        private static List<TeamModel> CreateTeams(int teamsCount)
        {
            List<TeamModel> teams = new List<TeamModel>();
            for (int i = 1; i <= teamsCount; i++)
            {
                TeamModel TmpTeam = new();
                TmpTeam.Id = i;
                TmpTeam.Name = "Team " + i;
                //TmpTeam.Round = 1;
                teams.Add(TmpTeam);
            }
            return teams;

        }

        public static List<MatchupModel> CreateMatchups(int teamsCount)
        {
            
            //int TeamsCount = 8;
            /// <summary>
            /// Create Teams and randomize order
            /// </summary>
            /// <returns></returns>
            List<TeamModel> teams = CreateTeams(teamsCount);
            RandomizeTeams(teams);

            List<MatchupModel> Matchups = new List<MatchupModel>();

            /// <summary>
            /// Create MatchupModels
            /// </summary>
            /// <returns></returns>

            int mIdCounter = 1;

            for (int i = 0; i < teams.Count(); i+= 2)
            {
                MatchupModel tmp = new();
                List<TeamModel> tmpTeamps = new();
                tmpTeamps.Add(teams[i]);
                tmpTeamps.Add(teams[i + 1]);

                tmp.Id = mIdCounter;
                tmp.Active = true;
                tmp.TeamsCompeting = tmpTeamps;
                //tmp.TeamsCompeting.Add(teams[i + 1]);
                tmp.Winner = null;
                tmp.Round = 1;
                mIdCounter++;
                tmpTeamps = new();
            }

         
            return Matchups;

        }

        public static Tree CreateLadder(int teamsCount)
        {
            List<MatchupModel> Matchups = CreateMatchups(teamsCount);
            Queue<Node> Nodes = new();

            /// <summary>
            /// Create Leafs for the Tree (First Round of Tournament) 
            /// </summary>
            /// 
            foreach (var matchup in Matchups)
            {
                Node Node = new();
                Node.Data = matchup;
                Node.Left = null;
                Node.Right = null;
                Nodes.Enqueue(Node);
            }

            /// <summary>
            /// Create Branches of the Tree (Rest of the rounds after Round 1)
            /// </summary>
            while (Nodes.Count > 1)
            {
                Node Node = new();
                MatchupModel TmpTeam = new MatchupModel() { Id = 0, Active = false };

                Node.Data = TmpTeam;
                Node.Left = Nodes.Dequeue();
                Node.Right = Nodes.Dequeue();
                Nodes.Enqueue(Node);
            }
            /// <summary>
            /// Create the Tree (Tournament Ladder)
            /// </summary>

            Tree ladder = new Tree();
            if (Nodes.Count == 0)
            {
                ladder = new Tree();
            }
            else
            {
                ladder = new Tree(Nodes.Dequeue());

            }
            return ladder;
        }
         

    }
}
