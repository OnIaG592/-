using System;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {

            Double a = AskAge();
            Double b = AskAge();
            Rectangle info = new Rectangle(a, b);
            info.Sides();
            info.Perimetr(a, b);
            double area = info.AreaofRectangle(a, b);
            Console.ReadKey();
        }
        static double AskAge()
        {
            Console.WriteLine("Введите стороны");
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
                        Console.WriteLine("Не правильный ввод;\nВведите заного");
                    }
                }
                catch { Console.WriteLine("Не правильный ввод;\nВведите заного"); }
            }
            while (a == false);
            return x;
        }
    }
    class Rectangle
    {
        private double a, b;

        public bool isRectangle
        {
            get
            {
                if (A == B)
                {
                    return true;
                }
                return false;
            }
            private set { }
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public Rectangle(double x, double y) { a = x; b = y; }
        public void Sides()
        {
            Console.WriteLine($"Стороны прямоугольника:{a} {b} ");
        }
        public void Perimetr(double a, double b)
        {
            if (isRectangle == false)
            {
                Double P = (a + b) * 2;
                Console.WriteLine($"Периметр прямоугольника равна : {P}");
            }
            else { double P = 4 * a; Console.WriteLine("Это Квадрат"); Console.WriteLine($"Периметр квадрата равна : {P}"); }
        }
        public double AreaofRectangle(double a, double b)
        {

            double S = a * b;
            Console.WriteLine($"Площадь прямоугольник равна : {S}");
            return S;
        }

    }
}
