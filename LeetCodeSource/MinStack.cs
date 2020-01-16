using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSource
{
    public class MinStack
    {

        /** initialize your data structure here. */

        private List<int> list;
        public MinStack()
        {
            list = new List<int>();
        }

        public void Push(int x)
        {
            list.Add(x);
        }

        public void Pop()
        {
            list.RemoveRange(list.Count-1,1);
        }

        public int Top()
        {
            return list[list.Count - 1];
        }

        public int GetMin()
        {
            int min = list[0];
            foreach (var i in list)
            {
                if (min > i)
                {
                    min = i;
                }
            }

            return min;
        }
    }

}
