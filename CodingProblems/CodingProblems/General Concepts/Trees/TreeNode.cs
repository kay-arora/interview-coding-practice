using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.General_Concepts.Trees
{
    //definition of a tree node
    public class TreeNode
    {
        public int val { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }

        public TreeNode(int val = 0, TreeNode leftChild = null, TreeNode rightChild = null)
        {
            this.val = val;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }
    }

    public static class SampleTree
    {
        public static TreeNode CreateBinaryTree()
        {
            return new TreeNode()
            {
                val = 50,
                LeftChild = new TreeNode()
                {
                    val = 25,
                    LeftChild = new TreeNode()
                    {
                        val = 10,
                        LeftChild = new TreeNode()
                        {
                            val = 4
                        },
                        RightChild = new TreeNode()
                        {
                            val = 11
                        }
                    },
                    RightChild = new TreeNode()
                    {
                        val = 33,
                        LeftChild = new TreeNode()
                        {
                            val = 30
                        },
                        RightChild = new TreeNode()
                        {
                            val = 40
                        }
                    }

                },
                RightChild = new TreeNode()
                {
                    val = 75,
                    LeftChild = new TreeNode()
                    {
                        val = 56,
                        LeftChild = new TreeNode()
                        {
                            val = 52
                        },
                        RightChild = new TreeNode()
                        {
                            val = 61
                        }
                    },
                    RightChild = new TreeNode()
                    {
                        val = 89,
                        LeftChild = new TreeNode()
                        {
                            val = 82
                        },
                        RightChild = new TreeNode()
                        {
                            val = 95
                        }
                    }
                }
            };
        }
    }
}
