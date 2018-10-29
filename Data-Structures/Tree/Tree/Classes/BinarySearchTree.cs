using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        public void Add(Node node)
        {
            Node curr = Root;
            while (curr != null)
            {
                if ((int)curr.Value > (int)node.Value)
                {
                    if (curr.Left == null)
                    {
                        curr.Left = node;
                        break;
                    }
                    curr = curr.Left;
                }
                else
                {
                    if (curr.Right == null)
                    {
                        curr.Right = node;
                        break;
                    }
                    curr = curr.Right;
                }
            }
        }

        public Node Search(Node node)
        {
            Node curr = Root;
            while (curr != null)
            {
                if ((int)curr.Value == (int)node.Value){
                    return curr;
                }

                if ((int)curr.Value > (int)node.Value)
                {
                    curr = curr.Left;
                }
                else
                {
                    curr = curr.Right;
                }
            }
            return null;
        }
    }
}
