using System;
using System.Collections.Generic;
using System.Text;

namespace Sortings
{
    class Selection
    {
        static void SelectionSortDescending(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int minInd = i;

                for (int j = i + 1; j < a.Length; j++)
                {

                    if (a[j] > a[minInd])
                    {
                        minInd = j;
                    }
                }
                var t = a[minInd];
                a[minInd] = a[i];
                a[i] = t;
            }
        }
        static void SelectionSort(int[] a)
        {
            for (var i = 0; i < a.Length - 1; i++)
            {
                var minInd = i;

                for (var j = i + 1; j < a.Length; j++)
                {

                    if (a[j] < a[minInd])
                    {
                        minInd = j;
                    }
                }
                var t = a[minInd];
                a[minInd] = a[i];
                a[i] = t;
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 2, 8, 1, 8, 1, 8, 2, 9, 3, -1, -76543, 76543, 876543, 65432, 8765432, 76543, 8765432, 765432 };

            foreach (var i in a)
            {
                Console.Write(i);
                Console.Write(' ');
            }

            Console.WriteLine();

            SelectionSort(a);

            foreach (var i in a)
            {
                Console.Write(i);
                Console.Write(' ');

            }
        }
    }
}
