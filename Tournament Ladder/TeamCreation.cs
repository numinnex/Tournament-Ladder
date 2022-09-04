using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Ladder.Models;

namespace Tournament_Ladder
{

    public static class TeamCreation
    {


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

        public static Tree CreateMatchups(int teamsCount)
        {
         
            Queue<Node> Nodes = new();
            

            /// <summary>
            /// Create Teams
            /// </summary>
            

            /// <summary>
            /// Create Leafs for the Tree (First Round of Tournament) 
            /// </summary>
            foreach (var team in teams)
            {
                Node Node = new();
                Node.Data = team;
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
                TeamModel TmpTeam = new TeamModel() { Id = 0 };

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
