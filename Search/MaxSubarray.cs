using System;

namespace Search
{
    class MaxSubarray
    {
        static (int, int, int) FindMaxCrossingSubarray(int[] a, int low, int mid, int high)
        {
            /*
             * Finding array with max sum that crosses mid point.
             */
            int left_sum = int.MinValue;
            int sum = 0;
            int max_left = mid;
            for (int i = mid; i >= low; i--)
            {
                sum += a[i];
                if (sum > left_sum)
                {
                    left_sum = sum;
                    max_left = i;
                }
            }

            int right_sum = int.MinValue;
            sum = 0;
            int max_right = mid + 1;
            for (int i = mid + 1; i <= high; i++)
            {
                sum += a[i];
                if (sum > right_sum)
                {
                    right_sum = sum;
                    max_right = i;
                }
            }
            return (max_left, max_right, right_sum + left_sum);
        }

        static (int, int, int) FindMaximumSubarray(int[] a, int low, int high)
        {
            if (high == low)
            {
                return (low, high, a[low]);
            }
            int mid = (int)Math.Floor((low + high) / 2.0);
            var (left_low, left_high, left_sum) = FindMaximumSubarray(a, low, mid);
            var (right_low, right_high, right_sum) = FindMaximumSubarray(a, mid+1, high);
            var (cross_low, cross_high, cross_sum) = FindMaxCrossingSubarray(a, low, mid, high);
            if (left_sum >= right_sum && left_sum >= cross_sum)
            {
                return (left_low, left_high, left_sum);
            } if (right_sum >= left_sum && right_sum >= cross_sum)
            {
                return (right_low, right_high, right_sum);
            }

            return (cross_low, cross_high, cross_sum);
        
        }

        static void Main(string[] args)
        {
            int[] a = {0, -1, -3, -24, -2, 3, 32, -52, 53, 325, 3};
            Console.WriteLine(FindMaximumSubarray(a, 0, a.Length-1));
        }
    }
}
