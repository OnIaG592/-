using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = AskAge();

            Days a = (Days)x;
            Console.WriteLine(a);




        }
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Staruday = 6,
            Sunday = 7
        }
        static int AskAge()
        {
            Console.WriteLine("Введите число недели");
            bool a = false;
            int x = 0;
            do
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x > 0 && x <= 7)
                    {
                        a = true;
                    }
                    else
                    {
                        Console.WriteLine("Не правильный ввод.Число недели должно быть от 1 до 7;\nВведите заного");
                    }
                }
                catch { Console.WriteLine("Не правильный ввод;\nВведите заного"); }
            }
            while (a == false);
            return x;
            Console.ReadKey();
        }
        
    }
}
