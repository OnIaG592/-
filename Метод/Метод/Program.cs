using System;

namespace Метод
{
    class Program
    {
        static void Main(string[] args)
        {


            string firstName = AskName();
            int firstAge = AskAge();
            string secondName = AskName();
            int secondAge = AskAge();
            string ask = whoIsOlder(firstName, secondName, firstAge, secondAge);
        }
        static string AskName()
        {
            Console.WriteLine("Введите имя:");
            bool b = false;
            string c = " ";
            do
            {
                try
                {
                    c = Console.ReadLine();
                    foreach (var item in c)
                    {
                        int temp = item.GetHashCode();
                        if (item >= '0' && item <= '9' || item == '\x20')
                        {
                            Console.WriteLine("Не правильный ввод;\nВведите заного");
                            b = false;
                            break;
                        }
                        else { b = true; }

                    }
                }
                catch
                {
                    Console.WriteLine("Не правильный ввод;\nВведите заного");

                }
            } while (b == false);


            return c;
        }
        static int AskAge()
        {
            Console.WriteLine("Введите возраст");
            bool a = false;
            int x = 0;
            do
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x > 0)
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
            return x;
        }
        static string whoIsOlder(string firstName, string secondName, int firstAge, int secondAge)
        {
            Console.WriteLine("Кто из них старше?");
            bool l = false;
            do
            {

                try
                {
                    string result = Console.ReadLine();
                    if (result == firstName && firstAge > secondAge)
                    {
                        Console.WriteLine($"Совершенно верно,{firstName} старше {secondName} на {firstAge - secondAge}лет");
                        l = true;
                    }
                    else if (result == secondName && secondAge > firstAge)
                    {
                        Console.WriteLine($"Совершенно верно,{secondName} старше {firstName} на {secondAge - firstAge}лет");
                        l = true;
                    }
                    else if (result == firstName && firstAge < secondAge)
                    {
                        Console.WriteLine($"Не правильно,{secondName} старше {firstName} на {secondAge - firstAge}лет");
                        l = true;
                    }
                    else if (result == secondName && firstAge > secondAge)
                    {
                        Console.WriteLine($"Не правильно,{firstName} старше {secondName} на {firstAge - secondAge}лет");
                        l = true;
                    }
                    else if (result == firstName || result == secondName && firstAge == secondAge)
                    {
                        Console.WriteLine("Они одного возраста");
                        l = true;
                    }
                    else { Console.WriteLine("Вы указали не верное имя;\n Укажите верное имя"); }

                }
                catch { Console.WriteLine("Не правильный ввод;\nВведите заного"); }

            }
            while (l == false);
            return Console.ReadLine();
        }
    }
}
