using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Ladder.Models;

namespace Tournament_Ladder
{
    public class Node
    {
        public MatchupModel? Data { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public int Depth()
        {
            return Depth(this);
        }
        /// <summary>
        /// Gets distance from current node to the leafs of tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Depth(Node root)
        {

            if (root != null)
            {
                int x = Depth(root.Left);
                int y = Depth(root.Right);
                if (x > y)
                    return x + 1;
                else
                    return y + 1;
            }
            return 0;
        }
    }
}
