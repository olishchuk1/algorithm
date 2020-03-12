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
        
    }
}
