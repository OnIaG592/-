using System;

namespace Массив9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];
            int i = 0;

            do
            {
                Console.WriteLine("Введите число массива");
                b[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            while (i < a);
            for (int d = 0; d < b.Length; d++)
            {
                for (int c = d + 1; c < b.Length; c++)
                {
                    if (b[c] < b[d])
                    {
                        int t = b[d];
                        b[d] = b[c];
                        b[c] = t;
                    }
                }
            }

            foreach (int item in b) { Console.WriteLine(item); }
            Console.ReadKey();
        }
    }
}
