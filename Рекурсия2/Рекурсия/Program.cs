using System;

namespace Рекурсия
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = AskAge();
            int y = AskAge();
            Console.WriteLine(Delitel(x, y));
            Console.ReadKey();
        }
        static int Delitel( int x,int y)
        {
            if (x == y)
            {
                return x;
            }
            else if(x>y)
            {
                int a = y;
                y = x;
                x = a;
            }
            return Delitel( x, y - x);
        }
        static int AskAge()
        {
            Console.WriteLine("Введите Число");
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
