using System;

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номиналы");
            int a = AskAge();
            Console.WriteLine("Введите кол-во купюр");
            int b = AskAge();
            Console.WriteLine("Введите цену товара");
            int c = AskAge();
            Money info = new Money(a, b);
            info.YouHave();
            info.YouCanBuy(a, b,c);
            info.Count(a, b,c);
            Console.ReadKey();
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
    class Money
    {
        private int first;
        private int second;
        public int A
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }
        public int B
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public int Sum { get { return A + B; } private set { } }
        public Money(int a,int b) { first = a;second = b; }
        public void YouHave()
        {
            Console.WriteLine($"У вас имеется {first} денег по {second} купюр ");
        }
        public bool YouCanBuy(int a, int b, int c) { if (a * b >= c) { 
                Console.WriteLine("У вас хватит денег на покупку");return true; }
            else { Console.WriteLine("Недостаточно средств");return false; }
        }
        public void Count(int a, int b, int c) { if (YouCanBuy(a,b,c) == true) 
            { Console.WriteLine($"Вы можете купить {(a*b)/c} штук"); } }

    }
}
