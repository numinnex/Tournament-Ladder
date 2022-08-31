using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Ladder
{
    internal class Node
    {
        public TeamModel Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }


        public int Depth()
        {
            return Depth(this);
        }
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
