using System;

namespace Счета
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            double summ = 0;
            double accountNum = 0;
            double openDate = 0;
            double summAmount = 0;
            

            do
            {
                Console.WriteLine("1)Физическое лицо\n2)Юридическое лицо\n3)Выход");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Ввведите сумму денег");
                        summ = AskNum();
                        Console.WriteLine("Ввведите номер счета");
                        accountNum = AskNum();
                        Console.WriteLine("Ввведите год открытия счета");
                        openDate = AskNum();
                        Console.WriteLine("Ввведите сумму денег которую хотите снять");
                        summAmount = AskNum();
                        Individual individual = new Individual(summ, accountNum, openDate,summAmount);
                        individual.Interest();
                        individual.GetCash();
                        break;
                    case "2":
                        Console.WriteLine("Ввведите сумму денег");
                        summ = AskNum();
                        Console.WriteLine("Ввведите номер счета");
                        accountNum = AskNum();
                        Console.WriteLine("Ввведите год открытия счета");
                        openDate = AskNum();
                        Entity entity = new Entity(summ, accountNum, openDate);
                        entity.Interest();
                        break;
                    case "3":
                        Console.WriteLine("Выход"); exit = true;
                        break;
                    default:
                        Console.WriteLine("Вы можете выбрать только эти пункты");
                        break;
                }
            } while (exit == false);
            Console.ReadKey();

            static string AskTypeOf()
            {

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
                                Console.WriteLine("Не правильный ввод;\nВведите заново");
                                b = false;
                                break;
                            }
                            else { b = true; }

                        }
                    }
                    catch
                    {
                        Console.WriteLine("Не правильный ввод;\nВведите заново");

                    }
                } while (b == false);


                return c;
            }
            static double AskNum()
            {

                bool a = false;
                double x = 0;
                do
                {
                    try
                    {
                        x = Convert.ToDouble(Console.ReadLine());
                        if (x > 0)
                        {
                            a = true;
                        }
                        else
                        {
                            Console.WriteLine("Не правильный ввод;\nВведите заново");
                        }
                    }
                    catch { Console.WriteLine("Не правильный ввод;\nВведите заново"); }
                }
                while (a == false);
                return x;
            }
        }
        class Account
        {
            public double summ { get; set; }
            public double accountNum { get; set; }
            public double openDate { get; set; }

            public Account(double Summ, double AccountNum, double OpenDate)
            {
                summ = Summ;
                accountNum = AccountNum;
                openDate = OpenDate;
            }
            public virtual void GetSumm()
            {
                Console.WriteLine($"У вас {summ} $");
            }
            public virtual void OpenDate()
            {
                Console.WriteLine(openDate);
            }
        }
        class Individual : Account
        {
            public double summAmount { get; set; }

            public Individual(double summ, double accountNum, double openDate, double summAmount) : base(summ, accountNum, openDate)
            { this.summAmount = summAmount; }

            public void Interest()
            {
                for (double i = openDate; i < 2021; i=i+1)
                {
                    summ = summ + (summ * 0.1);
                }
                Console.WriteLine($"У вас {summ} $ после начисления процентов");
            }
            public void GetCash()
            {
                if (summAmount >summ)
                {
                    Console.WriteLine("У вас не достаточно денег на счету");
                }
                else { Console.WriteLine($"У вас осталось {summ - summAmount}$"); }

            }
        }
        class Entity : Account
        {
            public Entity(double summ, double accountNum, double openDate) : base(summ, accountNum, openDate) { }
            public void Interest()
            {
                for (double i = openDate; i < 2021; i=i+1)
                {
                    summ = summ + (summ * 0.1);
                }
                Console.WriteLine($"У вас {summ} $ после начисления процентов");
            }
        }
    }
}