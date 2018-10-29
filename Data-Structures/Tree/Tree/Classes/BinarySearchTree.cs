using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Adds a node to Binary Search Tree.
        /// </summary>
        /// <param name="node">Node to be added</param>
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

        /// <summary>
        /// Searches for a Node in BST.
        /// </summary>
        /// <param name="node">Node to be searched</param>
        /// <returns>Target Node, or null if node doesn't exist</returns>
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
