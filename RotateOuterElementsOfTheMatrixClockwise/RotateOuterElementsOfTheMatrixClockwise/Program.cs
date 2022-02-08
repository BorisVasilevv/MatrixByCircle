using System;

namespace RotateOuterElementsOfTheMatrixClockwise
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int r = 6;//или пользователь вводит
            Random random = new Random();
            int[,] b = new int[6, 6];
            int[,] a = new int[6, 6];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                {
                    b[i, j] = random.Next() % 10;
                    a[i, j] = b[i, j];
                }
            b.PrintArray();
            for (int i = 0; i < r - 1; i++)
            {
                b[0, r - i - 1] = b[0, r - i - 2];
                b[r - i - 1, r - 1] = b[r - i - 2, r - 1];
                b[r - 1, i] = b[r - 1, i + 1];
                b[i, 0] = b[i + 1, 0];
            }
            b[0, 1] = a[0, 0];
            b[1, r - 1] = a[0, r - 1];
            b[r - 1, r - 2] = a[r - 1, r - 1];
            b[r - 2, 0] = a[r - 1, 0];

            Console.WriteLine("\n\n");
            b.PrintArray();
        }

        public static void PrintArray(this int[,] array)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
