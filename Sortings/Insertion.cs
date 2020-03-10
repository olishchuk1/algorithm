using System;

namespace Sortings
{
    class Insertion
    {
        static void InsertionSort(int[] a)
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

        static void Main(string[] args)
        {
            int[] a = {1, 5, 2, 8, 1, 8, 1, 8, 2, 9, 3, -1, -76543, 76543, 876543, 65432, 8765432, 76543, 8765432, 765432};

            foreach (var i in a)
            {
                Console.Write(i);
                Console.Write(' ');
            }

            Console.WriteLine();

            InsertionSort(a);

            foreach (var i in a)
            {
                Console.Write(i);
                Console.Write(' ');

            }
        }
    }
}
