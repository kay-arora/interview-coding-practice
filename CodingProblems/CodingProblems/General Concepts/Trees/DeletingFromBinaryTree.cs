using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.General_Concepts.Trees
{
    public static class DeletingFromBinaryTree
    {
        public static TreeNode DeleteElementFromTree(int val, TreeNode tree)
        {
            if (tree == null)
                return null;

            else if(val < tree.val)
            {
                tree.LeftChild = DeleteElementFromTree(val, tree.LeftChild);
                return tree;
            }
            else if(val > tree.val)
            {
                tree.RightChild = DeleteElementFromTree(val, tree.RightChild);
                return tree;
            }
            else if(val == tree.val)
            {
                if (tree.LeftChild == null)
                    return tree.RightChild;

                else if (tree.RightChild == null)
                    return tree.LeftChild;
                else
                {

                    tree.RightChild = Lift(tree.RightChild, tree);
                    return tree;
                }
            }

            return tree;
        }

        public static TreeNode Lift(TreeNode node, TreeNode nodeToDelete)
        {
            if(node.LeftChild != null)
            {
                node.LeftChild = Lift(node.LeftChild, nodeToDelete);
                return node;
            }
            else
            {
                nodeToDelete.val = node.val;
                return node.RightChild;
            }
        }
    }


 
}
