using System;

namespace Задание6
{
    class Program
    {
        static void Main(string[] args)
        {

            

            

            static int [] Random()
            {
            bool proverka = true;
                int values1 =0;
                int values2 = 0;
                int values3 = 0;
                int values4 = 0;

                while (proverka == true)
            {
                Random a = new Random();
                   values1 = a.Next(0, 9);
                   values2 = a.Next(0, 9);
                   values3 = a.Next(0, 9);
                   values4 = a.Next(0, 9);


                    if (values1 == values2 || values1 == values3 || values1 == values4 || values2 == values3 || values2 == values4 || values3 == values4) { proverka = true; }
                else { proverka = false;  }

                }
                int[] value = new int[4] { values1, values2, values3, values4 };
                return value;
            }

            string result =Game(Random(),num:0);

            Console.WriteLine(result);

            static string Game (int[] value,int num)
            {
                
                int biki = 0;
                int num1 = AskAge();
                int num2 = AskAge();
                int num3 = AskAge();
                int num4 = AskAge();

                int[] first = new int[4] { num1, num2, num3, num4 };
                int korovi = 0;
                
                string c = "Вы отгадали число";

                for (int i = 0; i < value.Length; i++)
                {
                    for (int s = 0; s < first.Length; s++)
                    {
                        if (first[s] == value[i])
                        {
                            biki++;
                            break;
                        }

                    }
                    if (value[i] == first[i])
                    {
                        korovi++;
                    }

                }

                if (korovi == 4) { return c; }
                else
                {
                    Console.WriteLine($"korovi={korovi},biki={biki}");
                    return Game(value,num++); }

            }
            Console.WriteLine();
            

           






            static int AskAge()
            {
                Console.WriteLine("Введите число");
                bool a = false;
                int num = 0;
                do
                {
                    try
                    {
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num >= 0)
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
                return num;
            }


        }
    }
}
