using System;

namespace Массивы
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


             int min = b[0];

            for (int c = 0; c < b.Length; c++)
            {
                if (min > b[c])
                {
                    min = b[c];
                }
            }

            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
