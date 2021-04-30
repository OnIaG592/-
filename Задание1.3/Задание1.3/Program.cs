using System;

namespace Задание1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Вашу зарплату");
            int Salary = AskAge();
            double a = 0.23;
            Console.WriteLine("Введите месяцы");
            int Month = AskAge();
            double c = Salary * a;

            Console.WriteLine($"Ваша net зарплата равна:{(Salary-c)*Month},Ваша налог = {c*Month},за {Month} месяцев.");
            
        }
        static int AskAge()
        {
            
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
        
    }
}
