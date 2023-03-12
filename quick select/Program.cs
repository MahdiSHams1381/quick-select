using System;
using System.Linq;
using System.Reflection;

namespace quick_select
{
    internal class Quick_Select
    {
        static void Main(string[] args)
        {
            int[] r = { 10, 4, 5, 8, 6, 11, 26 };
           Console.WriteLine(k_LowerElemnt(r,3));
        }
        // sowap tow element together
        #region sowap
        public static void sowap(int[] array, int arraynum1, int arraynum2)
        {
            int temp = array[arraynum1];
            array[arraynum1] = array[arraynum2];
            array[arraynum2] = temp;
        }
        #endregion
        //find the pivot (pivot is number that som numbers are biger than its and som numbers are lower than its)
        #region pivot
        public static int FindPivot(int[] array)
        {
            int pivot = 0;// that goes from 0 to last if the element be lower than its 
            for (int index = 0; index < array.Length - 1; index++)
            {
                // if this element be lower than last element
                if (array[0] < array[array.Length - 1])
                {
                    sowap(array, index, pivot);
                    pivot++;
                }
            }
            sowap(array, pivot, array.Length - 1);
            //return pivot element 
            return pivot;
        }
        #endregion
        public static int k_LowerElemnt(int[] array, int k)
        {
            if (k > array.Length || array.Length == 0 || k < 0)
            {
                throw new Exception();
            }
            int pivot = FindPivot(array);
            if (k == pivot)
            {
                return pivot;
            }
            else if (k < pivot)
            {
                int[] array2 = array.Select(n => n).Skip(array.Length-pivot+1).ToArray();
                return k_LowerElemnt(array2, k);
            }
            else
            {
                int[] array2 = array.Select(n => n).SkipLast(pivot-1).ToArray();
                return k_LowerElemnt(array2, k);
            }
        }
    }
}
