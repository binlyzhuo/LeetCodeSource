using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCodeSource.Array
{
    public class ArrayCode88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            System.Array.Copy(nums2, 0, nums1, m, n);

            System.Array.Sort(nums1);
        }
    }
}
