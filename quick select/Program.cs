using System;
using System.Reflection;

namespace quick_select
{
    internal class Quick_Select
    {
        static void Main(string[] args)
        {
            int[] r = { 10, 41, 5, 8, 6, 11, 26 };
            int a = FindPivot(r);
            Console.WriteLine(a);
        }
        // pivot is number that  is biger than some numbers in array and lower than other
        public static int FindPivot(int[] Array)
        {
            // if array dont have any element
            if (Array.Length == 0)
            {
               throw new Exception("array is not valiabel");
            }
            // if array have one element
            if (Array.Length == 1)
            {
               return Array[0];
            }
            int PivotLocal = 0; // when element is lower than end element
            int temp;
            for (int index = 0 ; index < Array.Length-1 ; index++)
            {
                // sowap the element index and PivotLocal
                if(Array[index] < Array[Array.Length - 1])
                {
                    temp = new int() ;
                    temp = Array[index];
                    Array[index] = Array[PivotLocal];
                    Array[PivotLocal] = temp;
                    PivotLocal++;
                }
            }
             temp = new int();
            temp = Array[Array.Length - 1];
            Array[Array.Length-1] = Array[PivotLocal];
            Array[Array.Length - 1] = temp;
            return Array[PivotLocal];

        }

    }
}
