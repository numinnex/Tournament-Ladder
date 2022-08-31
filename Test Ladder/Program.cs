using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace Test_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double test = Math.Log2(9);
            Console.WriteLine(test);

            Queue<Node> Nodes = new();

            List<TeamModel> teams = new List<TeamModel>();
            for(int i = 0; i < 8;i++)
            {
                TeamModel TmpTeam = new();
                TmpTeam.Id = i + 1;
                //TmpTeam.Round = 1;
                teams.Add(TmpTeam);
            }

            
            

            foreach(var team in teams)
            {
                Node Node = new();
                Node.Data = team;
                Node.Left = null;
                Node.Right = null;
                Nodes.Enqueue(Node);
            }


            while(Nodes.Count > 1)
            {
                //StringBuilder sb = new();
                Node Node = new();
                TeamModel TmpTeam = new TeamModel() { Id = 0 };
                Node.Data = TmpTeam;
                Node.Left = Nodes.Dequeue();
                Node.Right = Nodes.Dequeue();

               

                Nodes.Enqueue(Node);
            }


            Tree ladder = new Tree();
            if (Nodes.Count == 0)
            {
                ladder = new Tree();
            }
            else
            {
                ladder = new Tree(Nodes.Dequeue());
               
            }

            void ShowTeamIds(Node root)
            {
                Console.Write(root.Data.Id + ", ");
                
            }
            void SetupRounds(Node root)
            {
                root.Data.Round = root.Depth();
               
            }
            void ShowRounds(Node root)
            {
                Console.Write("R" + root.Data.Round + " ");
            }
            void MarkLosers(Node root)
            {
                if (root.Data.Id == 0)
                    if (root.Left.Data.Winner == true)
                        root.Right.Data.Winner = false;
                    else if (root.Right.Data.Winner == true)
                        root.Left.Data.Winner = false;
            }
           
    


            void ShowIsWinner(Node root)
            {
                Console.Write(root.Data.Winner);
                Console.WriteLine();
            }
            void AdvanceTeam(Node root)
            {
                if (root == null)
                    return;

                if (root.Data.Id == 0)
                {
                    if (root.Left.Data.Winner == true)
                    {
                        //Node tmp = new();
                        //tmp.Data = root.Left.Data;
                        //tmp.Data.Round = root.Data.Round;
                        //tmp.Data.isWinner = null;
                        //tmp.Left = null;
                        //tmp.Right = null;
                        //root = tmp;
                        root.Data = root.Left.Data;
                        root.Data.Winner = null;
                        root.Data.Round++;
                        root.Left = null;
                        root.Right = null;

                        //root.Data = tmp.Data;
                        //root.Left = tmp.Left;
                        //root.Right = tmp.Right;

                    }
                    else if (root.Right.Data.Winner == true)
                    {
                        //Node tmp = new();
                        //tmp.Data = root.Right.Data;
                        //tmp.Data.isWinner = null;
                        //tmp.Data.Round = root.Data.Round;
                        //tmp.Left = null;
                        //tmp.Right = null;
                        //root = tmp;
                        root.Data = root.Right.Data;
                        root.Data.Winner = null;
                        root.Data.Round++;
                        root.Left = null;
                        root.Right = null;
                        //root.Data = tmp.Data;
                        //root.Left = tmp.Left;
                        //root.Right = tmp.Right;
                    }
                    else
                        return;
                }
               
                    
                      
            }

            teams[0].Winner = true; //first team
            teams[3].Winner = true; //fourth team
            teams[4].Winner = true;
            teams[6].Winner = true;




            //void MoveWinners();

            int roundCount = (int)Math.Log2(teams.Count) + 1;

            Console.Write("Number of Rounds(log2 method) - ");
            Console.Write(roundCount);
            Console.WriteLine();

            int height = ladder.Height();
            Console.WriteLine("Number of rounds (Tree height method) - " + height);

            ladder.PostOrder(ladder.Root, ShowTeamIds);
            ladder.PostOrder(ladder.Root, SetupRounds);
            Console.WriteLine();
            ladder.PostOrder(ladder.Root, ShowRounds);
            ladder.PostOrder(ladder.Root, MarkLosers);
            ladder.PostOrder(ladder.Root, AdvanceTeam);
            //ladder.MoveRounds(ladder.Root);
            Console.WriteLine();
            Console.WriteLine("After Advancing Teams");
            ladder.PostOrder(ladder.Root, ShowTeamIds);
            Console.WriteLine();
            ladder.PostOrder(ladder.Root, ShowRounds);
            teams[0].Winner = true;
            teams[6].Winner = true;
            ladder.PostOrder(ladder.Root, AdvanceTeam);
            Console.WriteLine();
            
            Console.WriteLine("After Advancing Teams");
            ladder.PostOrder(ladder.Root, ShowTeamIds);
            Console.WriteLine();
            ladder.PostOrder(ladder.Root, ShowRounds);
            teams[0].Winner = true;
            ladder.PostOrder(ladder.Root, AdvanceTeam);
            Console.WriteLine();

            Console.WriteLine("After Advancing Teams");
            ladder.PostOrder(ladder.Root, ShowTeamIds);
            Console.WriteLine();
            ladder.PostOrder(ladder.Root, ShowRounds);


            //ladder.PostOrder(ladder.Root, ShowIsWinner);
            Console.ReadLine();
        }
    }
}