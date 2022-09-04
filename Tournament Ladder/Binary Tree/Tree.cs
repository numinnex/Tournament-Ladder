using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Ladder
{
    public class Tree
    {
        public Node Root;
        public delegate void OnVisit(Node root);

        public Tree()
        {
            Root = this.Root;
        }
        /// <summary>
        /// Tree constructor
        /// </summary>
        /// <param name="root"></param>
        public Tree(Node root)
        {
            Root = root;
        }
        /// <summary>
        /// Overload to remove the Node root parementer 
        /// </summary>
        /// <returns></returns>
        public int Height()
        {
            return Height(this.Root);
        }

        /// <summary>
        /// Height of the binary tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Height(Node root)
        {

            if (root != null)
            {
                int x = Height(root.Left);
                int y = Height(root.Right);
                if (x > y)
                    return x + 1;
                else
                    return y + 1;
            }
            return 0;
        }

        
        /// <summary>
        /// Post Order traversing 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="onVisit"></param>
        public void PostOrder(Node parent, OnVisit onVisit)
        {
            if (parent != null)
            {
                PostOrder(parent.Left, onVisit);
                PostOrder(parent.Right, onVisit);
                onVisit(parent);
            }
        }

        //TODO - REMOVE THAT SHIT

        /// <summary>
        /// Old Method of advancing teams
        /// </summary>
        /// <param name="root"></param>
        //    public void MoveTeams(Node root)
        //    {
        //        if (root == null)
        //            return;

        //        if(root.Data.Id == 0)
        //            if(root.Left.Data.Winner == true)
        //            {
        //                Node tmp = new();
        //                tmp.Data = root.Left.Data;
        //                tmp.Left = null;
        //                tmp.Right = null;
        //                root.Data = tmp.Data;
        //                root.Left = tmp.Left;
        //                root.Right = tmp.Right;

        //            }
        //            else if (root.Right.Data.Winner == true)
        //            {
        //                Node tmp = new();
        //                tmp.Data = root.Right.Data;
        //                tmp.Left = null;
        //                tmp.Right = null;
        //                root.Data = tmp.Data;
        //                root.Left = tmp.Left;
        //                root.Right = tmp.Right;
        //            }
        //        MoveTeams(root.Left);
        //        MoveTeams(root.Right);
        //    }



    }
}
