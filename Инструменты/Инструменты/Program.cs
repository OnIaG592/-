using System;

namespace Инструменты
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            int countOfStrings = 0;
            int size = 0;
            int dieameter = 0;
            string answer = "";
            MyArray arr = new MyArray();
            do
            {
                Console.WriteLine("Выберите инструмент");
                Console.WriteLine("\n1)Гитара\n2)Барабан\n3)Труба\n4)Выход");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Введите кол-во струн");
                        countOfStrings = AskNum();
                        arr[1] = new Guitar(countOfStrings); 
                        arr[1].Play();
                        break;
                    case "2":
                        Console.WriteLine("Введите размер");
                        size = AskNum();
                        arr[2] = new Drum(size);
                        arr[2].Play();
                        break;
                    case "3":
                        Console.WriteLine("Введите диаметр");
                        dieameter = AskNum();
                        arr[3] = new Trumpet(dieameter);
                        arr[3].Play();
                        break;
                    case "4":
                        Console.WriteLine("Выход");exit = false;
                        break;
                    default:
                        Console.WriteLine("Выберите существующие пункты");
                        break;
                }

            } while (exit==true);
            Console.ReadKey();


        }
        static int AskNum()
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
                        Console.WriteLine("Не правильный ввод;\nВведите заново");
                    }
                }
                catch { Console.WriteLine("Не правильный ввод;\nВведите заново"); }
            }
            while (a == false);
            return x;
        }
    }
    interface ITool
    {
        public const string key = "До мажор";
        public void Play() { Console.WriteLine(key); }

    }
    class Guitar : ITool { 
        public int countOfStrings { get; set; }
        public Guitar(int countOfStrings) { this.countOfStrings =countOfStrings ; }
        public void  Play()
        {
            Console.WriteLine($"{ITool.key}; Играет гитара у которого: {countOfStrings} струн");
        }
    }
    class Drum : ITool {
        public int size { get; set; }
        public Drum(int size) { this.size = size; }
        public void Play()
        {
            Console.WriteLine($"{ITool.key};Играет барабан у которого размер: {size} ");
        }
    }
    class Trumpet : ITool { 
        public int diameter { get; set; }
        public Trumpet(int diameter) { this.diameter = diameter; }
        public void Play()
        {
            Console.WriteLine($"{ITool.key};Играет труба у которого диаметр: {diameter} ");
        }
    }
    class MyArray
    {
        ITool[] data;
        public MyArray()
        {
            data = new ITool[100];
        }
        public ITool this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}
