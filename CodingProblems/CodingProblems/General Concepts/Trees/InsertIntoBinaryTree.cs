using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.General_Concepts.Trees
{
    public static class InsertIntoBinaryTree
    {
        public static void InsertElementToTree(int val, TreeNode tree)
        {
            if(val < tree.val)
            {
                if(tree.LeftChild == null)
                {
                    var newNode = new TreeNode(val);
                    tree.LeftChild = newNode;
                }
                else
                {
                    InsertElementToTree(val, tree.LeftChild);
                }
            }
            else if(val > tree.val)
            {
                if(tree.RightChild == null)
                {
                    var newNode = new TreeNode(val);
                    tree.RightChild = newNode;
                }
                else
                {
                    InsertElementToTree(val, tree.RightChild);
                }
            }
        }
    }
}
