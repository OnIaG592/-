using System;

namespace Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Размер массива");
            int n = AskAge();
            Array info = new Array(n);
            Console.WriteLine("Введите скаляр");
            info.Skalyar= AskAge();
            Console.WriteLine("Введите числа массива");
            info.Elements();
            info.Item();
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
    class Array
    {
        private int[] array;
        public int n;
        public int[] A
        {
            get
            {
                return array;
            }
            set
            {
                array = value;
            }
        }
        public int B
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }

        public int Lenght { get { return n; } private set { } }
        public int Skalyar
        {
            private get { return Skalyar; }
            set
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] *= value;
                }
            }
        }
        public Array (int N) { n = N; array = new int[n]; }
        public void Elements()
        {
            for (int i = 0; i < array.Length; i++)
            {
                 array[i] = AskAge();
            } }
        public void BubbleSort(int[]array) {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void Item()
        {
            foreach (var item in array)
            {
                Console.WriteLine($"Числа массива :{item}");
            }
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
