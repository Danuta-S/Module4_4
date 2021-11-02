using System;

namespace Module4_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };
            var arrayOperator = new ArrayOperator(arr1, 10);
            arrayOperator.CopyOfArray();
        }
    }
}