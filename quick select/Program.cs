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
        }
        public static void sowap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        public static int pivot(int[] array)
        {
            int pivot = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < array[array.Length - 1])
                {
                    sowap(array, index, pivot);
                    pivot++;
                }
            }
            sowap(array, pivot, array.Length - 1);
            return pivot;
        }
        public static int k_LowerElement(int[]array , int k)
        {
            if (k > array.Length || k < 0)
            {
                throw new Exception();
            }
           int piv =  pivot(array);
            if(piv == k)
            {

            }
            else if(piv < k)
            {
                int[] a = array.Select(n => n).SkipLast(piv).ToArray();
            }
            else
            {

                int[] a = array.Select(n => n).Skip(array.Length - piv).ToArray();KD
            }
        }
    }

}
