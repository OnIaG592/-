using System;

namespace Массив7
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

            int counter = 0;

            for (int k = 0; k < b.Length; k++)
            {
                if (b[k] % 2 != 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
