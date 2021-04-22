using System;

namespace Массив4
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
            int maxIndex = 0;
            int max = b[0];

            for (int c = 0; c < b.Length; c++)
            {
                if (max < b[c])
                {
                    max = b[c];
                    maxIndex = c;
                }
            }

            Console.WriteLine(maxIndex);
            Console.ReadKey();
        }
    }
}
