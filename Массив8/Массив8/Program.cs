using System;

namespace Массив8
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
            int f = b.Length / 2;
            int r = f + b.Length % 2;

            for (int k = 0; k < f; k++)
            {
                int t = b[k];
                b[k] = b[r + k];
                b[r + k] = t;
            }
            foreach ( int number in b) { Console.WriteLine(number); }
            Console.ReadKey();

            
        }
    }
}
