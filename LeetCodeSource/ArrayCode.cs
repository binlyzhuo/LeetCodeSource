using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSource
{
    public class ArrayCode
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            
            int p1 = m - 1;
            int p2 = n - 1;
            int p = m + n - 1;

            while ((p1>=0)&&(p2>=0))
            {
                nums1[p--] = (nums1[p1] < nums2[p2]) ? nums2[p2--] : nums1[p1--];
            }

            //nums2.CopyTo(nums1,0);
            foreach (var x in nums1)
            {
                Console.Write(x+",");
            }
        }

        public int MajorityElement(int[] nums)
        {
            int num=0;
            int max =0;

            Dictionary<int,int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;

                    if(dict[nums[i]]>max)
                    {
                        max = dict[nums[i]];
                        num = nums[i];
                    }
                }
                else
                {
                    dict.Add(nums[i],1);
                }
            }


            //foreach (var kv in dict)
            //{
            //    if (kv.Value > max)
            //    {
            //        max = kv.Value;
            //        num = kv.Key;
            //    }
            //}

            return num;
        }

        public void Rotate(int[] nums, int k)
        {

        }

        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                    if (dict[nums[i]] >= 2)
                        return true;
                }
                else
                {
                    dict.Add(nums[i],1);
                }
            }
            return false;
        }

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            HashSet<int> hs = new HashSet<int>();
            for(int i=0;i<nums.Length;i++)
            {
                if (hs.Contains(nums[i]))
                    return true;
                hs.Add(nums[i]);

                if (hs.Count > k)
                    hs.Remove(nums[i-k]);
            }

            return false;
        }

        public int MissingNumber(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            for(int i=0;i<nums.Length;i++)
            {
                hs.Add(nums[i]);
            }

            for(int i=0;i<=nums.Length;i++)
            {
                if (!hs.Contains(i))
                    return i;
            }

            return 0;
        }
    }
}
