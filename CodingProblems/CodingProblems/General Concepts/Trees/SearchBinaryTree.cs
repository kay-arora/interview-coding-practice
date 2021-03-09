using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.General_Concepts.Trees
{
    public static class SearchBinaryTree
    {
        public static bool SearchForElementInTree(int value, TreeNode tree)
        {
            //recursive condition end is when the tree node is null or value has been found
            if (tree == null)
                return false;

            if (tree.val == value)
                return true;

            if(value < tree.val)
                 return SearchForElementInTree(value, tree.LeftChild);

            if (value > tree.val)
                return SearchForElementInTree(value, tree.RightChild);

            return false;
        }
    }
}
