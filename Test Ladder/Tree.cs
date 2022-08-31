using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test_Ladder
{
    internal class Tree
    {
        public Node Root;
        internal delegate void OnVisit(Node root);

        public Tree()
        {
            Root = this.Root;
        }

        public Tree(Node root)
        {
            Root = root;
        }

        public int Height()
        {
            return Height(this.Root);
        }

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

        

        public void PostOrder(Node parent, OnVisit onVisit)
        {
            if (parent != null)
            {
                PostOrder(parent.Left, onVisit);
                PostOrder(parent.Right, onVisit);
                onVisit(parent);
            }
        }
        public void MoveRounds(Node root)
        {
            if (root == null)
                return;

            if(root.Data.Id == 0)
                if(root.Left.Data.Winner == true)
                {
                    Node tmp = new();
                    tmp.Data = root.Left.Data;
                    tmp.Left = null;
                    tmp.Right = null;
                    root.Data = tmp.Data;
                    root.Left = tmp.Left;
                    root.Right = tmp.Right;

                }
                else if (root.Right.Data.Winner == true)
                {
                    Node tmp = new();
                    tmp.Data = root.Right.Data;
                    tmp.Left = null;
                    tmp.Right = null;
                    root.Data = tmp.Data;
                    root.Left = tmp.Left;
                    root.Right = tmp.Right;
                }
            MoveRounds(root.Left);
            MoveRounds(root.Right);
        }

      

    }
}
