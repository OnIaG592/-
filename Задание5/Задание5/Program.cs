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
            Console.WriteLine("Введите числа массива");
            info.Elements();
            Console.WriteLine("Введите скаляр");
            info.Skalyar = AskAge();
            info.Item();
            info.BubbleSort();
            Console.WriteLine("Отсортированный массив");
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
        private int n;
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
        
        public Array(int N) { n = N; array = new int[n]; }
        public void Elements()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = AskAge();
            }
        }
        public int Skalyar
        {
            private get { return array[n]; }
            set
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] *= value;

                }
            }
        }
        public void BubbleSort()
        {
            for (int i = 0; i < array.Length-1; i++)
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
