using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSource
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = TrailingZeroes(30);
            int[] arr = { 2, 7, 11, 15 };
            int day = MaxProfit(arr);

            int[] numbers = { 2, 7, 11, 15 };
            int[] indexs = TwoSum(numbers, 9);

            ArrayCode arrayCode = new ArrayCode();
            int[] a1 = {1, 2, 3, 0, 0, 0};
            int[] a2 = { 2,5,6};
            arrayCode.Merge(a1,3,a2,3);

            int[] b1 = {1, 2, -2147483648};
            int tmax = arrayCode.ThirdMax(b1);

            int[] b2 = { 1 };
            int maxLength = arrayCode.FindMaxConsecutiveOnes(b2);


            int[] b3 = {3, 1, 4, 1, 5};
            int mathCount = arrayCode.FindPairs(b3, 2);

            int[] b4 = {1,3,5,7 };
            int maxLl = arrayCode.FindLengthOfLCIS(b4);

            Console.ReadLine();
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;

            

            while (i<j)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new[] { ++i,++j};
                }
                else if(numbers[i]+numbers[j]>target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }

            return new int[2];
        }

        public static int TrailingZeroes(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n / 5;
                n = n / 5;
            }
            return count;

        }

        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            
            for (int i = prices.Length - 1; i > 0; i--)
            {
                for (int j = i-1; j >=0; j--)
                {
                    int val = prices[i] - prices[j];
                    if (max < val)
                    {
                        max = val;
                        
                    }
                        
                }
            }

            return max;
        }
    }
}
