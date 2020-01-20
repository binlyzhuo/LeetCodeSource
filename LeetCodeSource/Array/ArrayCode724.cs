using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSource.Array
{
    public class ArrayCode724
    {
        public int PivotIndex(int[] nums)
        {
            int sum = nums.Sum();
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum * 2 + nums[i] == sum)
                    return i;

                leftSum += nums[i];
            }

            return -1;
        }
    }
}
