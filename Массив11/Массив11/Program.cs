using System;

namespace Массив11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите имя первого");
            bool d = false;
            bool e = false;
            string firstName = "0";
            string secondName = "1";
            do {
                try
                {
                firstName = Console.ReadLine();
                    foreach (var item in firstName)
                    {
                        if (item >= '0' && item <= '9') 
                        { Console.WriteLine("Не правильный ввод;\nВведите заного");
                            d = false;
                            break;
                        }
                        else { d = true; }
                        
                    }
                }
                catch 
                {
                    Console.WriteLine("Не правильный ввод;\nВведите заного");

                }
            } while (d==false);
            
            bool a = false;
            int firstAge = 0;
            int secondAge = 0;

            Console.WriteLine("Ввведите возраст первого");
            do
            {
                try
                {
                    firstAge = Convert.ToInt32(Console.ReadLine());
                    if (firstAge > 0)
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

            Console.WriteLine("Ввведите имя второго");
            do
            {
                try
                {
                    secondName = Console.ReadLine();
                    foreach (var item in secondName)
                    {
                        if (item >= '0' && item <= '9')
                        {
                            Console.WriteLine("Не правильный ввод;\nВведите заного");
                            e = false;
                            break;
                        }
                        else { d = true; }

                    }
                }
                catch
                {
                    Console.WriteLine("Не правильный ввод;\nВведите заного");

                }
            } while (e == false);
            bool b = false;
            Console.WriteLine("Ввведите возраст второго");
            do
            {
                try
                {
                    secondAge = Convert.ToInt32(Console.ReadLine());
                    if (secondAge > 0)
                    { b = true; }
                    else { Console.WriteLine("Не правильный ввод;\nВведите заного"); }
                }
                catch { Console.WriteLine("Не правильный ввод;\nВведите заного"); }
            }
            while (b == false);
            bool c = false;
            Console.WriteLine("Кто из них старше?");

            do
            {

                try
                {
                    string result = Console.ReadLine();
                    if (result == firstName && firstAge > secondAge)
                    {
                        Console.WriteLine($"Совершенно верно,{firstName} старше {secondName} на {firstAge - secondAge}лет");
                        c = true;
                    }
                    else if (result == secondName && secondAge > firstAge)
                    {
                        Console.WriteLine($"Совершенно верно,{secondName} старше {firstName} на {secondAge - firstAge}лет");
                        c = true;
                    }
                    else if (result == firstName && firstAge < secondAge)
                    {
                        Console.WriteLine($"Не правильно,{secondName} старше {firstName} на {secondAge - firstAge}лет");
                        c = true;
                    }
                    else if (result == secondName && firstAge > secondAge)
                    {
                        Console.WriteLine($"Не правильно,{firstName} старше {secondName} на {firstAge - secondAge}лет");
                        c = true;
                    }
                    else if (result == firstName || result == secondName && firstAge == secondAge)
                    {
                        Console.WriteLine("Они одного возраста");
                        c = true;
                    }
                    else { Console.WriteLine("Вы указали не верное имя;\n Укажите верное имя"); }

                }
                catch { Console.WriteLine("Не правильный ввод;\nВведите заного"); }

            }
            while (c == false);

            Console.ReadKey();
        }
    }
}
