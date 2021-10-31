using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_4
{
    public class ArrayOperator
    {
        public void CopyOfArray()
        {
            int[] array1 = { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };
            int[] array2 = array1;
            Console.WriteLine($"array1: {string.Join(", ", array1)}");
            Console.Write($"array2: {string.Join(", ", array2)}");
            Console.ReadLine();
        }

        public int[] arr = new int[10];

        public void InputValues()
        {
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
        }

        public void CountDuplicates()
        {
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
        }
    }
}
