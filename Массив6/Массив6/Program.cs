using System;

namespace Массив6
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


            int[] y = new int[a];

            for (int k = 0; k < b.Length; k++)
            {
                y[k] = b[a - 1];
                a = a - 1;
            }

            foreach (int numElement in y)

                Console.WriteLine(numElement);
            Console.Read();
        }
    }
}
