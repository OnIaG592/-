using System;
using System.IO;

namespace ReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(001, 12345678, 22);
            Client client1 = new Client(025, 87652134, 50);
            Client client2 = new Client(034, 87652134, 12);
            bool exit = true;
            bool choice = true;
            do
            {
                Console.WriteLine("Вы хотите внести изменения?\n'y'/'n'");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        
                        do
                        {
                            Console.WriteLine("Какого клиента вы хотите поменять?\n1)Первого\n2)Второго\n3)Третьего\n4)Выход");
                            answer = Console.ReadLine();
                            switch (answer)
                            {
                                case "1":
                                    Console.WriteLine("Что именно вы хотите поменять?\n1)ID\n2)Пасспорт\n3)Сумму");
                                    answer = Console.ReadLine();
                                    switch (answer)
                                    {
                                        case "1":
                                            Console.WriteLine("Внесите изменения");
                                            client = new Client(AskNum(), 12345678, 22);
                                            break;
                                        case "2":
                                            Console.WriteLine("Внесите изменения");
                                            client = new Client(001, AskNum(), 22);
                                            break;
                                        case "3":
                                            Console.WriteLine("Внесите изменения");
                                            client = new Client(001, 12345678, AskNum());
                                            break;
                                        case "4": choice = false;
                                            break;
                                        default:
                                            Console.WriteLine("Вы можете выбрать только существующие варианты!");
                                            break;
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Что именно вы хотите поменять?\n1)ID\n2)Пасспорт\n3)Сумму");
                                    answer = Console.ReadLine();
                                    switch (answer)
                                    {
                                        case "1":
                                            Console.WriteLine("Внесите изменения");
                                            client1 = new Client(AskNum(), 12345678, 22);
                                            break;
                                        case "2":
                                            Console.WriteLine("Внесите изменения");
                                            client1 = new Client(001, AskNum(), 22);
                                            break;
                                        case "3":
                                            Console.WriteLine("Внесите изменения");
                                            client1 = new Client(001, 12345678, AskNum());
                                            break;
                                        case "4":
                                            choice = false;
                                            break;
                                        default:
                                            Console.WriteLine("Вы можете выбрать только существующие варианты!");
                                            break;
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Что именно вы хотите поменять?\n1)ID\n2)Пасспорт\n3)Сумму");
                                    answer = Console.ReadLine();
                                    switch (answer)
                                    {
                                        case "1":
                                            Console.WriteLine("Внесите изменения");
                                            client2 = new Client(AskNum(), 12345678, 22);
                                            break;
                                        case "2":
                                            Console.WriteLine("Внесите изменения");
                                            client2 = new Client(001, AskNum(), 22);
                                            break;
                                        case "3":
                                            Console.WriteLine("Внесите изменения");
                                            client2 = new Client(001, 12345678, AskNum());
                                            break;
                                        case "4":
                                            choice = false;
                                            break;
                                        default:
                                            Console.WriteLine("Вы можете выбрать только существующие варианты!");
                                            break;
                                    }
                                    break;
                                case "4": choice = false;
                                    break;
                                default:
                                    Console.WriteLine("Вы можете выбрать только один из вариантов");
                                    break;
                            }

                        } while (choice==true);
                        break;
                    case "n":
                        exit = false;
                        break;
                }
            } while (exit == true);
            static int AskNum()
            {

                bool a = false;
                int x = 0;
                do
                {
                    try
                    {
                        x = Convert.ToInt32(Console.ReadLine());
                        if (x >= 0)
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

            string path = @"C:\Домашка";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            using (FileStream fstream = new FileStream($"{path}\\note.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(client.Print());
                fstream.Write(array, 0, array.Length);
                byte[] array1 = System.Text.Encoding.Default.GetBytes(client1.Print());
                fstream.Write(array1, 0, array1.Length);
                byte[] array2 = System.Text.Encoding.Default.GetBytes(client2.Print());
                fstream.Write(array2, 0, array2.Length);
                Console.WriteLine("Текст записан в файл");
            }
        }
        class Client
        {
            private int Id { get; set; }
            private int PassportNumber { get; set; }
            private int Payment { get; set; }

            public Client(int Id, int PassportNumber, int Payment)
            {
                this.Id = Id;
                this.PassportNumber = PassportNumber;
                this.Payment = Payment;
            }
            public string Print() { return $"\nID-{Id};Passportnumber-AZE{PassportNumber};Payment-{Payment}"; }

        }
    }
}
