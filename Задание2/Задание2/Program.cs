using System;

namespace Задание2 { 
class Program
{
    static void Main(string[] args)
    {

        Double a = AskAge();
        Double b = AskAge();
        Double c = AskAge();
        Triangle info = new Triangle(a, b, c);
        info.Sides();
        info.Perimetr(a, b, c);
        double area = info.AreaofTriangle(a, b, c);
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
class Triangle
{
    private double a, b, c;

    public bool isTriangle
    {
        get
        {
            if (a + b > c && a + c > b && b + c > a)
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
    public double C
    {
        get
        {
            return c;
        }
        set
        {
            c = value;
        }
    }
    public Triangle(double x, double y, double z) { a = x; b = y; c = z; }
    public void Sides()
    {
        Console.WriteLine($"Стороны треугольника:{a} {b} {c}");
    }
    public void Perimetr(double a, double b, double c)
    {
        if (isTriangle == true)
        {
            Double P = a + b + c;
            Console.WriteLine($"Периметр треугонилька равна : {P}");
        }
        else { Console.WriteLine("Такого треугольника не существует"); }
    }
    public double AreaofTriangle(double a, double b, double c)
    {
        double poluperimetr = (a + b + c) / 2;
        double S = Math.Sqrt(poluperimetr * (poluperimetr - a) * (poluperimetr - b) * (poluperimetr - c));
        Console.WriteLine($"Площадь треугонилька равна : {S}");
        return S;
    }

}
}