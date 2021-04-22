using System;

namespace Массив5
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
            int c = 0;
            int k = 1;

            do
            {
                if (Convert.ToBoolean(k % 2 != 0))
                {
                    c = c + b[k];
                    k = k + 2;

                }
            }

            while (k < a);

            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
