using System;

namespace Рекурсия4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = AskAge();
            int y = AskAge();
            Console.WriteLine(SumBeetween(x,y));
            Console.ReadKey();
        }
        static int SumBeetween(int x,int y)
        {   if (x > y)
            {
                return y + SumBeetween(y +1, x);
            }
            else if (x == y)
            {
                return 0;
            }
            else
            {
                
                return x+SumBeetween(x+1, y);
            }
        }
        static int AskAge()
        {
            Console.WriteLine("Введите числа");
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
