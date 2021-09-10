using System;

namespace Sort_algorithms
{
    public class QuickSort
    {
        public static void Sort<T>(T[] array) where T: IComparable
        {
            Sort(array, 0, array.Length-1);
        }

        private static T[] Sort<T>(T[] array, int low, int high) where T: IComparable
        {
            if(low < high)
            {
                int p = AdditionalMethods.Partition(array, low, high);
                Sort(array, low, p);
                Sort(array, p+1, high);
            }
            return array;
        }
    }
}