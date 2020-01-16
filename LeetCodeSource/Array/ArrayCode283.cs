using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSource.Array
{
    public class ArrayCode283
    {
        public void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    
                    int t = i;
                    while (t<nums.Length-1)
                    {
                        int temp = nums[t];
                        nums[t] = nums[t + 1];
                        nums[t + 1] = temp;

                        t++;
                    }
                }
            }

            int count = nums.Length;
        }
    }
}
