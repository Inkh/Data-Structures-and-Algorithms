using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Class
{
    public class Tree
    {
        public Node Root { get; set; }

        public Tree(Node root)
        {
            Root = root;
        }
    }
}
