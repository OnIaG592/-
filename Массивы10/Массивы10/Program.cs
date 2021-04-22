using System;

namespace Массивы10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            a[0] = 0;
            a[1] = 1;
            for (int d = 2; d < a.Length; d++)
            {
                a[d] = a[d - 1] + a[d - 2];
            }

            foreach (int item in a) 
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
