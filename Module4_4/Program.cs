using System;

namespace Module4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = {12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1};
            int[] Array2 = new int[Array1.Length];
            for (int i = 0; i < Array1.Length; i++)
            {
                Array2[i] = Array1[i];
            }

            Console.Write($"Array1: {string.Join(", ", Array1)} == Array2: {string.Join(", ", Array2)}");
            Console.ReadLine();
        }
    }
}
