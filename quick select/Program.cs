using System;
using System.Linq;
using System.Reflection;

namespace quick_select
{
    internal class Quick_Select
    {
        static void Main(string[] args)
        {
            int[] r = { 4, 5, 9, 2, 6, 8 };
            Console.WriteLine(k_LowerElement(r, 4));
        }
        public static void sowap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        public static int pivot(int[] array)
        {
           
            int pivot = 0;
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
        public static int k_LowerElement(int[] array, int k)
        {
            if (k > array.Length || k < 0)
            {
                throw new Exception();
            }
            int piv = pivot(array);
            if (piv == k)
            {
                return array[piv];
            }
            else if (piv < k)
            {
                int[] temp = array.Select(n => n).Skip(piv).ToArray();
                return k_LowerElement(temp, k - piv);
            }
            else
            {
                int[] temp = array.Select(n => n).SkipLast(array.Length - piv).ToArray();
                return k_LowerElement(temp, k);
            }
        }
    }

}

//// C# program of Quick Select
//using System;

//class GFG
//{

//    // partition function similar to quick sort
//    // Considers last element as pivot and adds
//    // elements with less value to the left and
//    // high value to the right and also changes
//    // the pivot position to its respective position
//    // in the readonly array.
//    static int partitions(int[] arr, int low, int high)
//    {
//        int pivot = arr[high], pivotloc = low, temp;
//        for (int i = low; i <= high; i++)
//        {
//            // inserting elements of less value
//            // to the left of the pivot location
//            if (arr[i] < pivot)
//            {
//                temp = arr[i];
//                arr[i] = arr[pivotloc];
//                arr[pivotloc] = temp;
//                pivotloc++;
//            }
//        }

//        // swapping pivot to the readonly pivot location
//        temp = arr[high];
//        arr[high] = arr[pivotloc];
//        arr[pivotloc] = temp;

//        return pivotloc;
//    }

//    // finds the kth position (of the sorted array)
//    // in a given unsorted array i.e this function
//    // can be used to find both kth largest and
//    // kth smallest element in the array.
//    // ASSUMPTION: all elements in []arr are distinct
//    static int kthSmallest(int[] arr, int low,
//                                int high, int k)
//    {
//        // find the partition
//        int partition = partitions(arr, low, high);

//        // if partition value is equal to the kth position,
//        // return value at k.
//        if (partition == k)
//            return arr[partition];

//        // if partition value is less than kth position,
//        // search right side of the array.
//        else if (partition < k)
//            return kthSmallest(arr, partition + 1, high, k);

//        // if partition value is more than kth position,
//        // search left side of the array.
//        else
//            return kthSmallest(arr, low, partition - 1, k);
//    }

//    // Driver Code
//    public static void Main(String[] args)
//    {
//        int[] array = { 4, 5, 9, 2, 6, 8 };
//        int[] arraycopy = { 4, 5, 9, 2, 6, 8 };

//        int kPosition = 5;
//        int length = array.Length;

//        if (kPosition > length)
//        {
//            Console.WriteLine("Index out of bound");
//        }
//        else
//        {
//            // find kth smallest value
//            Console.WriteLine("K-th smallest element in array : " +
//                                kthSmallest(arraycopy, 0, length - 1,
//                                                        kPosition - 1));
//        }
//    }
//}

//// This code is contributed by 29AjayKumar
