using System;

namespace Sortings
{
    class Insertion
    {
        static void InsertionSortDescending(int[] a)
        {
            for (var i = 1; i < a.Length; i++)
            {
                var t1 = a[i];
                var j = i;

                while (j >= 1 && a[j - 1] < t1)
                {
                    var t2 = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = t2;

                    j--;
                }
                a[j] = t1;

            }

        }

        private static void InsertionSort(int[] a)
        {
            for (var i = 1; i < a.Length; i++)
            {
                var t1 = a[i];
                var j = i;

                while (j >= 1 && a[j - 1] > t1)
                {
                    var t2 = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = t2;

                    j--;
                }
                a[j] = t1;

            }

        }
    }
}
