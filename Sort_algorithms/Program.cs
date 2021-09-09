using System;

namespace Sort_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableToSort = new int[] {25, 3, 96, -46, 57, 14, -34, 11};
            Console.WriteLine("Before sort: ");
            foreach(int num in tableToSort)
            {
                Console.Write("{0} ", num);
            }

            DateTime start = DateTime.Now;
            SelectionSort.Sort<int>(tableToSort);
            DateTime end = DateTime.Now;
            
            TimeSpan ts = (end - start);

            Console.WriteLine("\nAfter sort: ");
            foreach(int num in tableToSort)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine("\nExecution time: ");
            Console.WriteLine(ts.TotalMilliseconds);
        }
    }
}
