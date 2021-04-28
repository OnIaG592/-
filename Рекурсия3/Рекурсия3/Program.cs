using System;

namespace Рекурсия3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = AskAge();
            int y = AskAge();
            Console.WriteLine(Square(x,y));
            Console.ReadKey();
        }
        static int Square(int x,int y)
        {
            if (y == 1)
            {
                return x;
            }
            else
            {
                return x * Square(x, --y);
            }
        }
        static int AskAge()
        {
            Console.WriteLine("Введите число и степень");
            bool a = false;
            int num = 0;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0)
                    {
                        a = true;
                    }
                    else
                    {
                        Console.WriteLine("Не правильный ввод;\nВведите заного");
                    }
                }
                catch { Console.WriteLine("Не правильный ввод;\nВведите заного"); }
            }
            while (a == false);
            return num;
        }
    }
}
