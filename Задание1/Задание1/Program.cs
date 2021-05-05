using System;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point info = new Point();
            info.Coordinate();
            info.X = info.AskAge();
            info.Y = info.AskAge();
            info.Coordinate();
            info.Distance(info.X, info.Y);
            double skalyarA = info.AskAge();
            info.Skalyar = skalyarA;
            info.Vektor();
            Console.ReadKey();

        }
    }

    class Point
    {
        private double x, y = 0;



        public double AskAge()
        {
            Console.WriteLine("Введите координаты");
            bool a = false;
            double x = 0;
            do
            {
                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    if (x >= 0 || x <= 0)
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
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public void Coordinate()
        {
            Console.WriteLine($"Координаты точки: {x},{y}");
        }
        public double Distance(double x, double y)
        {
            double rangeX = Math.Pow(x, 2);
            double rangeY = Math.Pow(y, 2);
            double range = Math.Sqrt(rangeX + rangeY);
            return range;

        }
        public double Skalyar
        {
            set
            {
                x = x * value;
                y = y * value;
                Console.WriteLine($"Скаляр {x},{y}");
            }
        }
        public Point() { }
        public Point(int num, int num1) { this.x = num; this.y = num1; }
        public void Vektor()
        {

            double a = AskAge();
            double b = AskAge();
            double c = AskAge();
            double d = AskAge();

            if (a == c && b == d) { Console.WriteLine("Такого вектора не сушествует"); }
            if (a > c && a > x && b > d && b > y) { x = a - x; y = b - y; Console.WriteLine($"Точка сместится на {x} по оси Х,и на {y} по оси Y"); }
            if (a < c && c > x && b < d && d > y) { x = c - x; y = d - y; Console.WriteLine($"Точка сместится на {x} по оси Х,и на {y} по оси Y"); }
            if (a > c && a < x && b > d && b < y) { x = x - a; y = y - b; Console.WriteLine($"Точка сместится на {x} по оси Х,и на {y} по оси Y"); }
            if (a < c && c < x && b < d && d < y) { x = x - c; y = y - d; Console.WriteLine($"Точка сместится на {x} по оси Х,и на {y} по оси Y"); }




        }
    }
}