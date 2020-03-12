using System;
using System.Collections.Generic;
using System.Text;

namespace Sortings
{
    class Merge
    {
        static void MergeHelper(int[] a, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
            {
                L[i] = a[p + i];
            }

            for (j = 0; j < n2; j++)
            {
                R[j] = a[q + 1 + j];
            }

            i = 0;
            j = 0;
            k = p;

            while (i < n1 && j < n2)
            {

                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }

                else
                {
                    a[k] = R[j];
                    j++;
                }

                k++;
            }
            while (i < n1)
            {
                a[k] = L[i];

                i++;
                k++;
            }
            while (j < n2)
            {
                a[k] = R[j];

                j++;
                k++;
            }

        }

        static void MergeSort(int[] a, int p, int r) 
        {
            if (r > p)
            {
                int q = p + (r - p) / 2;
                MergeSort(a, p, q);
                MergeSort(a, q+1, r);
                MergeHelper(a, p, q, r);
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

            MergeSort(a, 0, a.Length - 1);

            foreach (var i in a)
            {
                Console.Write(i);
                Console.Write(' ');

            }
        }
    }
}
