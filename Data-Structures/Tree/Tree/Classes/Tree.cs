using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<Node> List { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// Method for PreOrder. Instantiate new List for population.
        /// </summary>
        /// <returns>List Property of Tree</returns>
        public List<Node> PreOrder()
        {
            List = new List<Node>();
            PreOrder(Root);
            return List;
        }

        /// <summary>
        /// Pre Order traversal of tree. Prints value first before going further.
        /// </summary>
        /// <param name="root">Root Node</param>
        public void PreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.Value);
            List.Add(root);
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        /// <summary>
        /// Method for InOrder. Instantiate new List for population.
        /// </summary>
        /// <returns>List Property of Tree</returns>
        public List<Node> InOrder()
        {
            List = new List<Node>();
            InOrder(Root);
            return List;
        }

        /// <summary>
        /// In order traversal. Prints all left nodes before heading to the right.
        /// </summary>
        /// <param name="root">Root Node</param>
        public void InOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.Left);
            Console.WriteLine(root.Value);
            List.Add(root);
            InOrder(root.Right);
        }

        /// <summary>
        /// Method for PostOrder. Instantiate new List for population.
        /// </summary>
        /// <returns>List Property of Tree</returns>
        public List<Node> PostOrder()
        {
            List = new List<Node>();
            PostOrder(Root);
            return List;
        }

        /// <summary>
        /// Post Order traversal. Outputs child nodes first.
        /// </summary>
        /// <param name="root">Root Node</param>
        public void PostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.WriteLine(root.Value);
            List.Add(root);
        }

        /// <summary>
        /// Returns the size of Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns>Size of Tree</returns>
        public int Size(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return Size(root.Left) + 1 + Size(root.Right);
        }
    }
}
