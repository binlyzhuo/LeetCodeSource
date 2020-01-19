using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSource.Array
{
    public class ArrayCode532
    {
        public int FindPairs(int[] nums, int k)
        {
            int pairCount = 0;
            System.Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if(i>0&&nums[i]==nums[i-1])
                    continue;

                for (int j = i+1; j < nums.Length; j++)
                {
                    if (System.Math.Abs(nums[i] - nums[j]) == k)
                    {
                        pairCount++;
                        break;
                    }
                        
                }
            }
            return pairCount;
        }
    }
}
