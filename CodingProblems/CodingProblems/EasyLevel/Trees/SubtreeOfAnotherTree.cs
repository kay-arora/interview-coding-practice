using CodingProblems.General_Concepts.Trees;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Trees
{
    public class SubtreeOfAnotherTree
    {
        public bool IsSubTree(TreeNode tree, TreeNode subTree)
        {
            string tree1 = Preorder(tree, true);
            string tree2 = Preorder(subTree, true);
            if (tree1.Contains(tree2))
                return true;

            return false;
        }

        public string Preorder(TreeNode tree, bool left)
        {
            if(tree == null)
            {
                if (left)
                    return "LN";
                else
                    return "RN";
            }

            return "#" + tree.val + " " + Preorder(tree.LeftChild, true)  + " " + Preorder(tree.RightChild, false);
        }

        public bool IsSubTreeByNodeComparison(TreeNode tree, TreeNode subTree)
        {
            return Traverse(tree, subTree);
        }

        public bool Traverse(TreeNode tree, TreeNode subTree)
        {
            return tree != null && (Compare(tree, subTree) || Traverse(tree.LeftChild, subTree) || Traverse(tree.RightChild, subTree));
        }

        public bool Compare(TreeNode tree, TreeNode subTree)
        {
            if (tree == null && subTree == null)
                return true;
            if (tree == null || subTree == null)
                return false;

            return tree.val == subTree.val && Compare(tree.LeftChild, subTree.LeftChild) && Compare(tree.RightChild, subTree.RightChild);
        }

        public TreeNode CreateTree()
        {
            return new TreeNode()
            {
                val = 1,
                LeftChild = new TreeNode()
                {
                    val = 2,
                }
            };
        }

        public TreeNode CreateSubTree()
        {
            return new TreeNode()
            {
                val = 2
            };
        }

    }
}
