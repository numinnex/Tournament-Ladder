using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Ladder.Interfaces;
using Tournament_Ladder.Models;

namespace Tournament_Ladder
{

    public static class LadderCreation
    {
        /// <summary>
        /// Randomize the team order method
        /// </summary>
        /// <param name="teams"></param>
        /// <returns></returns>
        private static List<ITeam> RandomizeTeams(List<ITeam> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

        /// <summary>
        /// Create the teams method
        /// </summary>
        /// <param name="teamsCount"></param>
        /// <returns></returns>
        private static List<ITeam> CreateTeams(int teamsCount)
        {
            List<ITeam> teams = new List<ITeam>();
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
        /// <summary>
        /// Created the matchups 
        /// </summary>
        /// <param name="teamsCount"></param>
        /// <returns></returns>
        public static List<MatchupModel> CreateMatchups(int teamsCount)
        {
            

            /// <summary>
            /// Create Teams and randomize order
            /// </summary>
            /// <returns></returns>
            List<ITeam> teams = CreateTeams(teamsCount);
            teams = RandomizeTeams(teams);

            List<MatchupModel> Matchups = new List<MatchupModel>();

            /// <summary>
            /// Create MatchupModels
            /// </summary>
            /// <returns></returns>
            int mIdCounter = 1;

            for (int i = 0; i < teams.Count(); i+= 2)
            {
                MatchupModel tmp = new();
                List<ITeam> tmpTeamps = new();
                tmpTeamps.Add(teams[i]);
                tmpTeamps.Add(teams[i + 1]);

                tmp.Id = mIdCounter;
                tmp.TeamsCompeting = tmpTeamps;
                tmp.Winner = null;
                tmp.Round = 1;
                
                tmpTeamps = new();
                mIdCounter++;
                Matchups.Add(tmp);
            }

         
            return Matchups;

        }
        /// <summary>
        /// Create the tournament ladder
        /// </summary>
        /// <param name="teamsCount"></param>
        /// <returns></returns>
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
            /// 

            int NextMatchupId = Matchups.Last().Id+1;
            while (Nodes.Count > 1)
            {
                Node Node = new();
                MatchupModel TmpTeam = new MatchupModel() { Id = NextMatchupId,  TeamsCompeting = new() };
                NextMatchupId++;

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
