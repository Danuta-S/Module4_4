using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_4
{
    public class ArrayOperator
    {
        private int[] array1;
        private int[] array2;

        public ArrayOperator(int[] array1, int arrSize2)
        {
            this.array1 = array1;
            this.array2 = new int[arrSize2];
        }

        public int[] Array1
        {
            get { return Array1; }
            set { Array1 = value; }
        }

        public int[] Array2
        {
            get { return array2; }
            set { Array2 = value; }
        }

        public void CopyOfArray()
        {
            int[] array2 = array1;
            Console.WriteLine($"array1: {string.Join(", ", array1)}");
            Console.Write($"array2: {string.Join(", ", array2)}");
            Console.ReadLine();
        }
    }
}
