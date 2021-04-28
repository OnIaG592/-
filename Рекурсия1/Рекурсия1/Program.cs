using System;

namespace Рекурсия1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfSquares(2,10));   
        }

        static int SumOfSquares(int x,int y)
        {
            if (y == 2)
            {
                return 4;
            }
            else
            {
                return x*x+(x * SumOfSquares(x, --y));
            }
            Console.ReadKey();
        }

    }
}
