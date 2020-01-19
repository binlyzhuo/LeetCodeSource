using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSource.Array
{
    public class ArrayCode56
    {
        public int ArrayPairSum(int[] nums)
        {
            int sum = 0;
            System.Array.Sort(nums);
            for (int i = 0; i < nums.Length; i+=2)
            {
                sum += nums[i];
                
            }

            return sum;
        }
    }
}
