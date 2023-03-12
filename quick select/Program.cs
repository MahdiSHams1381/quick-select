using System;
using System.Linq;
using System.Reflection;

namespace quick_select
{
    //find the k_th element that is lower (k_th lower)
    internal class Quick_Select
    {
        static void Main(string[] args)
        {
            //notic the k should be k=k-1
            //test case = 4,5,1,3,7,9
            //result
            int[] array = { 4,5,1,3,7,9};
            Console.WriteLine(k_LowerElement(array , 5));
        }
        //sowap tow number in array with index of them
        public static void sowap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        //find pivot (pivot is number that is biger than some numbers and lower than other)
        public static int pivot(int[] array)
        {
            //is number that goes when number is lower than last number
            int pivot = 0;
            //choos a number (we choos last number) and the numbers are biger than last number sowap it 
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
        //find a k_th number (after sorting the k_th number of array)
        public static int k_LowerElement(int[] array, int k)
        {
            //when k is - and is boger than array length (should array length > k > 0)
            if (k > array.Length || k < 0)
            {
                throw new Exception();
            }
            // find pivot 
            int piv = pivot(array);
            if (piv == k)
            {
                return array[piv];
            }
            // if k is lower than pivot ( the k_th element is on the left)
            else if (piv < k)
            {
                int[] temp = array.Select(n => n).Skip(piv).ToArray();
                return k_LowerElement(temp, k - piv);
            }
            else
            // if k is biger than pivot ( the k_th element is on the Right)
            {
                int[] temp = array.Select(n => n).SkipLast(array.Length - piv).ToArray();
                return k_LowerElement(temp, k);
            }
        }
    }

}
