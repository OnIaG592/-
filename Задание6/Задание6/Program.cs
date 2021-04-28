using System;

namespace Задание6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = AskAge();
            int num2 = AskAge();
            int num3 = AskAge();
            int num4 = AskAge();
            Random a = new Random();
            string value =Convert.ToString(a.Next(1000,9999));
            Console.WriteLine(value);
            var ask = Game(num1, num2, num3, num4);
            
              /*  for (int i = 0; i < 4; i++ )
             while( value[i]!=value[i+1]);*/


            
        }

        static string Game (int num1,int num2,int num3,int num4,string x)
        {
            int korovi = 0;
            int biki = 0;
            int popitki = 0;

            if (korovi == 4)
            {
                Console.WriteLine("Вы угадали число");
            }
            else if (num1 == x[0]) { korovi++; }
            else if (num2 == x[1]) { korovi++; }
            else if (num3 == x[2]) { korovi++; }
            else if (num4 == x[3]) { korovi++; }
            else if ()

        }

        static int AskAge()
        {
            Console.WriteLine("Введите 4-x значное число");
            bool a = false;
            int num = 0;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num >= 0)
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
