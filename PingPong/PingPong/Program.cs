using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = true;
            do
            {
                bool queue = true;
                static void DisplayMessage(string message) { Console.WriteLine(message); };
                Console.WriteLine("1-Выбор первой пары.\n2-Выбор второй пары.\n3-Выход");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Введите имя первого игрока");
                        string playerOne = Askname();
                        Console.WriteLine($"{playerOne} играет клавишей '1'");
                        Console.WriteLine("Введите имя второго игрока");
                        string playerTwo = Askname();
                        Console.WriteLine($"{playerTwo} играет клавишей '2'");
                        Console.WriteLine($"Первым ходит игрок {playerOne}");
                        do
                        {
                            Console.WriteLine($"1-Играет :{playerOne}\n2-Играет :{playerTwo}\n3-Выход");
                            string ask = Console.ReadLine();
                            switch (ask)
                            {
                                case "1":
                                    if (queue==true)
                                    {
                                        Ping ping = new Ping(playerOne);
                                        ping.Notify += DisplayMessage;
                                        ping.Play(playerOne);
                                        queue = false;
                                    }
                                    else { Console.WriteLine("Очередь второго игрока"); }

                                    break;
                                case "2":
                                    if (queue == false)
                                    {
                                        Pong pong = new Pong(playerTwo);
                                        pong.Notify += DisplayMessage;
                                        pong.Play(playerTwo);
                                        queue = true;
                                    }
                                    else { Console.WriteLine("Очередь первого игрока"); }
                                    break;
                                case "3":
                                    Console.WriteLine("Выход");exit = false;
                                    break;
                                default:
                                    Console.WriteLine("Выберите один из соответствующих пунктов");
                                    break;
                            }
                        } while (exit == true);
                        exit = true;
                        break;
                    case "2":
                        Console.WriteLine("Введите имя третьего игрока");
                        string playerThree = Askname();
                        Console.WriteLine($"{playerThree} играет клавишей '1'");
                        Console.WriteLine("Введите имя четвертого игрока");
                        string playerFour = Askname();
                        Console.WriteLine($"{playerFour} играет клавишей '2'");
                        Console.WriteLine($"Первым ходит игрок {playerThree}");
                        do
                        {
                            Console.WriteLine($"1-Играет :{playerThree}\n2-Играет :{playerFour}\n3-Выход");
                            string ask = Console.ReadLine();
                            switch (ask)
                            {
                                case "1":
                                    if (queue == true)
                                    {
                                        Ping ping = new Ping(playerThree);
                                        ping.Notify += DisplayMessage;
                                        ping.Play(playerThree);
                                        queue = false;
                                    }
                                    else { Console.WriteLine("Очередь четвертого игрока"); }

                                    break;
                                case "2":
                                    if (queue == false)
                                    {
                                        Pong pong = new Pong(playerFour);
                                        pong.Notify += DisplayMessage;
                                        pong.Play(playerFour);
                                        queue = true;
                                    }
                                    else { Console.WriteLine("Очередь третьего игрока"); }
                                    break;
                                case "3":
                                    Console.WriteLine("Выход"); exit = false;
                                    break;
                                default:
                                    Console.WriteLine("Выберите один из соответствующих пунктов");
                                    break;
                            }
                        } while (exit == true);
                        exit = true;
                        break;
                    case "3":
                        Console.WriteLine("Выход"); exit = false;
                        break;
                    default:
                        Console.WriteLine("Выбеите одну из пар");
                        break;
                }

            } while (exit == true);
            Console.ReadKey();
        }
        static string Askname()
        {

            bool check = false;
            string name = "";
            do
            {
                try
                {
                  name = Console.ReadLine();
                    foreach (var item in name)
                    {
                        int temp = item.GetHashCode();
                        if (item >= '0' && item <= '9' || item == '\x20')
                        {
                            Console.WriteLine("Не правильный ввод;\nВведите заново");
                            check = false;
                            break;
                        }
                        else { check = true; }

                    }
                }
                catch
                {
                    Console.WriteLine("Не правильный ввод;\nВведите заново");

                }
            } while (check == false);


            return name;
        }

        class Ping
        {
            public delegate void Game(string message);

            public event Game Notify;
            private string player { get; set; }
            public  Ping (string player)
            {
                player = this.player;
            }
            public void Play (string player) 
            {
                Notify?.Invoke($"{player} сделал : Ping");
            }
        }
        class Pong
        {
            public delegate void Game(string message);

            public event Game Notify;
            private string Secondplayer { get; set; }
            public Pong(string player)
            {
                player = this.Secondplayer;
            }
            public void Play(string Secondplayer)
            {
                Notify?.Invoke($"{Secondplayer} сделал : Pong");
            }
        }
    }
}
