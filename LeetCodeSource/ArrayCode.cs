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

        public int ThirdMax(int[] nums)
        {
            int firstMax = int.MinValue;
            int secondMax = int.MinValue;
            int thirdMax = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > firstMax)
                    firstMax = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]==firstMax)
                    continue;

                if (nums[i] > secondMax)
                    secondMax = nums[i];
            }

            int tCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == firstMax||nums[i]==secondMax)
                    continue;

                tCount++;
                if (nums[i] > thirdMax)
                    thirdMax = nums[i];
            }

            if (firstMax >int.MinValue&&secondMax>int.MinValue&&tCount>0)
                return thirdMax;
            return firstMax;
        }

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            IList<int> lostInts = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                hs.Add(nums[i]);
            }

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!hs.Contains(i))
                {
                    lostInts.Add(i);
                }
            }

            return lostInts;
        }

        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int count =0;
            int maxCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count = count + 1;
                }
                else
                {
                    maxCount = maxCount >= count ? maxCount : count;
                    count = 0;
                }
            }

            return  maxCount >= count ? maxCount : count;
        }

        public int FindPairs(int[] nums, int k)
        {
            int mathCount = 0;
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int last = nums[j];
                    
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        mathCount++;
                    }
                        
                }
            }

            return mathCount;
        }

        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int maxLen = 1;
            int res = 1;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] - nums[i + 1] < 0)
                {
                    maxLen += 1;
                }
                else
                {
                    maxLen = 1;
                }

                res = res < maxLen ? maxLen : res;
            }

            return res;
        }

        public int MaximumProduct(int[] nums)
        {
            if (nums.Length < 3)
                return 0;
            int maxVal=int.MinValue;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int temp = nums[i] * nums[i + 1] * nums[i + 2];
                if (temp > maxVal)
                {
                    maxVal = temp;
                }
            }

            return maxVal;
        }
    }
}
