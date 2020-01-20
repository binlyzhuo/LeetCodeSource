using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSource.Array
{
    public class ArrayCode189
    {
        public void Rotate(int[] nums, int k)
        {
            int[] arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[(i + k) % nums.Length] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = arr[i];
            }
        }
    }
}
