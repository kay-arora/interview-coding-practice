using CodingProblems.General_Concepts.Trees;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel
{
    public class LongestPathOfTree
    {
        int sum = 0;
        public int FindLongestPath(TreeNode tree)
        {
            Depth(tree);
            return sum;
        }

        public int Depth(TreeNode node)
        {
            if (node == null) return 0;
            int leftDepth = Depth(node.LeftChild);
            int rightDepth = Depth(node.RightChild);
            //sum of depths tracked till now
            sum = Math.Max(sum, leftDepth + rightDepth);
            //return current depth to parent node
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }
}
