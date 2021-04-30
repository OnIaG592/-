using System;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xleb = 0.45;
            double Moloko = 2.35;
            double Sol = 0.56;
            double Cola = 1.34;
            double Sladosti = 5;
            double Araxis = 1.49;
            double Sigareti = 3.94;
            double Jevachka = 0.73;
            double Sum = AskAge();

            double[] magaz = { Xleb, Moloko, Sol, Cola, Sladosti, Araxis, Jevachka, Sigareti };

            int i = 0;
            int counter = 0;

            while (Sum > magaz[i]) 
            {
                Sum = Sum - magaz[i];
                i = i + 1;
                counter++;
            } 

            double[] nedostatok = new double[magaz.Length- counter];

            for (int n = 0; n < magaz.Length-counter; n++)
            {
                nedostatok[n] = magaz[i];
                i++;
            }



            foreach (var item in nedostatok)
            {
                Console.WriteLine(item);
            }





           

        }
        static int AskAge()
        {
            Console.WriteLine("Введите вашу сумму денег(максимальное кол-во:14)");
            bool a = false;
            int x = 0;
            do
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x > 0 && x <=14)
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
