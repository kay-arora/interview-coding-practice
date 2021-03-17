using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems.EasyLevel.Arrays
{
    public class MinStack
    {
        //we need to define a stack which stores key value pairs
        //int[]{x,y} where x => element being pushed and y => min element at that stage
        public Stack<int[]> _stack;
        
        
        public MinStack()
        {
            _stack = new Stack<int[]>();     
        }

        public void Push(int x)
        {
            if(_stack.Count == 0)
            {
                _stack.Push(new int[] { x, x });
            }
            else
            {
                var currMin = _stack.Peek()[1];
                _stack.Push(new int[] { x, Math.Min(currMin, x) });
            }

        }

        public void Pop()
        {
            _stack.Pop();
        }

        public int Top()
        {
            return _stack.Peek()[0];
        }

        public int GetMin()
        {
            return _stack.Peek()[1];
        }
    }
}
