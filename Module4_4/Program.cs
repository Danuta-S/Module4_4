using System;

namespace Module4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1};
            int[] array2 = array1;

            //int[] array2 = new int[array1.Length];

            //array1.CopyTo(array2, 0);

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array2[i] = array1[i];
            //}

            Console.WriteLine($"array1: {string.Join(", ", array1)}");
                Console.Write($"array2: {string.Join(", ", array2)}");
            Console.ReadLine();

            #region Count all duplicates in the array
            var arr = new int[10];

            for (var i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please input value with index {i}");

                if (int.TryParse(Console.ReadLine(), out var input))
                {
                    arr[i] = input;
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Duplicate number is: {arr[i]}");
                    }
                }
            }
            Console.ReadLine();
            #endregion
        }
    }
}