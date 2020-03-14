using System;

namespace Matrices
{
    class Multiply
    {
        static int[,] matrixMultiply(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int[,] c = new int[n, n];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    c[i, j] = 0;
                    for (var k = 0; k < n; k++)
                    {
                        c[i, j] += (a[i, k] * b[k, j]);
                    }
                }
            }

            return c;
        }

        static void printMatrix(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            int n = 4;
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = i + j;
                    b[i, j] = i * j;
                }
            }

            int[,] c = matrixMultiply(a, b);

            printMatrix(a);
            Console.Write("\n");
            printMatrix(b);
            Console.Write("\n");
            printMatrix(c);

        }
    }
}
