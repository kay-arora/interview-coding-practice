using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.General_Concepts.Trees
{
    public static class TreeTraversal
    {
        public static void InfixTraversal(TreeNode node)
        {
            //we need to visit the left tree first, then parent, then right tree
            if(node != null)
            {
                InfixTraversal(node.LeftChild);
                Console.WriteLine(node.val);
                InfixTraversal(node.RightChild);
            }
        }

        public static void PrefixTraversal(TreeNode node)
        {
            //root is always visited first
            if(node != null)
            {
                Console.WriteLine(node.val);
                PrefixTraversal(node.LeftChild);
                PrefixTraversal(node.RightChild);
            }
        }

        public static void PostfixTraversal(TreeNode node)
        {
            //root is always visited last
            if(node != null)
            {
                PostfixTraversal(node.LeftChild);
                PostfixTraversal(node.RightChild);
                Console.WriteLine(node.val);
            }
        }
    }
}
