using System;

namespace Sort_algorithms
{
    public static class AdditionalMethods
    {
        public static void Swap<T>(T[] array, int num1, int num2)
        {
            T temp = array[num1];
            array[num1] = array[num2];
            array[num2] = temp;
        }

        public static int Partition<T>(T[] array, int low, int high) where T: IComparable
        {
            int i = low;
            int j = high;
            T pivot = array[low];
            do
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if(i >= j) {break;}
                Swap(array, i, j);
            }
            while(i <= j);
            return j;
        }
    }
}