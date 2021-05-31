using System;
using System.Collections;

namespace Araylist
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int studentCounter = 0;
            int aspirantCounter = 0;
            int studentNumber = 0;
            int aspirantNumber = 0;
            int studentIndex = 0;
            int aspirantIndex = 0;
            ArrayList list = new ArrayList();
            ArrayList list1 = new ArrayList();

            do
            {
                Console.WriteLine("1)Добавить Студента\n2)Добавить Аспиранта\n3)Вывести количество студентов\n4)Вывести количество аспирантов\n5)Вывести список всех студентов\n6)Вывести список всех аспирантов\n7)Вывести студента по порядковому индексу\n8)Вывести аспиранта по порядковому индексу\n9)Удаление студента по порядковому индексу\n10)Удаление аспиранта по порядковому индексу\n11)Выход из приложения");
                string answer = Console.ReadLine();
                int size = studentCounter + 1;
                int size1 = aspirantCounter + 1;
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Введите фамилию студента:");
                        string surname = AskSurname();
                        Console.WriteLine("Введите на каком курсе студент:");
                        int kurs = AskNum();
                        Console.WriteLine("Введите номер Зачетки студента:");
                        int recordBook = AskNum();
                        Student student = new Student(surname, kurs, recordBook);
                        list.Add(new Student(surname, kurs, recordBook));
                        studentCounter++;
                        break;
                    case "2":
                        bool phdDefence = true;
                        Console.WriteLine("Введите фамилию Аспиранта:");
                        surname = AskSurname();
                        Console.WriteLine("Введите на каком курсе аспирант:");
                        kurs = AskNum();
                        Console.WriteLine("Введите номер Зачетки аспиранта:");
                        recordBook = AskNum();
                        list1.Add(new Aspirant(surname, kurs, recordBook, phdDefence));
                        aspirantCounter++;
                        break;
                    case "3":
                        Console.WriteLine($"Учатся {studentCounter} студент (а).");
                        break;
                    case "4":
                        Console.WriteLine($"Учатся {aspirantCounter} аспирант (а).");
                        break;
                    case "5":
                        if (studentCounter == 0)
                        {
                            Console.WriteLine("Студентов нет");
                        }
                        foreach (object o in list)
                        {
                            Console.WriteLine(o);
                        }
                        break;
                    case "6":
                        if (aspirantCounter == 0)
                        {
                            Console.WriteLine("Аспирантов нет");
                        }
                        foreach (object o in list1)
                        {
                            Console.WriteLine(o);
                        }
                        break;
                    case "7":
                        Console.WriteLine("Введите порядковый номер студента");
                        studentNumber = AskNum();
                        if (studentNumber >= 0 && studentNumber < size)
                        {
                            Console.WriteLine(list[studentNumber]);
                        }
                        else { Console.WriteLine("Студента под таким порядковым номером не существует!"); }
                        break;
                    case "8":
                        Console.WriteLine("Введите порядковый номер аспиранта");
                        aspirantNumber = AskNum();
                        if (aspirantNumber >= 0 && aspirantNumber < size1)
                        {
                            Console.WriteLine(list1[aspirantNumber]);
                        }
                        else { Console.WriteLine("Аспиранта под таким порядковым номером не существует!"); }
                        break;
                    case "9":
                        Console.WriteLine("Введите порядковый номер студента которого нужно удалить");
                        studentIndex = AskNum();
                        if (studentIndex > studentCounter)
                        {
                            Console.WriteLine("Студента под таким номером не существует");
                        }
                        else
                        {
                            list.RemoveAt(studentIndex);
                            size = size - 1;
                            studentCounter = studentCounter - 1;
                        }
                        break;
                    case "10":
                        Console.WriteLine("Введите порядковый номер аспиранта которого нужно удалить");
                        aspirantIndex = AskNum();
                        if (aspirantIndex > aspirantCounter)
                        {
                            Console.WriteLine("Аспиранта под таким номером не существует");
                        }
                        else
                        {
                            list1.RemoveAt(aspirantIndex);
                            size1 = size1 - 1;
                            aspirantCounter = aspirantCounter - 1;
                        }
                        break;
                    case "11":
                        Console.WriteLine("Выход"); exit = true;
                        break;
                    default:
                        Console.WriteLine("Вы можете ввести цифру от 1 до 11");
                        break;
                }
            } while (exit == false);
            static string AskSurname()
            {

                bool exit = false;
                string ask = " ";
                do
                {
                    try
                    {
                        ask = Console.ReadLine();
                        foreach (var item in ask)
                        {
                            int temp = item.GetHashCode();
                            if (item >= '0' && item <= '9' || item == '\x20')
                            {
                                Console.WriteLine("Не правильный ввод;\nВведите заново");
                                exit = false;
                                break;
                            }
                            else { exit = true; }

                        }
                    }
                    catch
                    {
                        Console.WriteLine("Не правильный ввод;\nВведите заново");

                    }
                } while (exit == false);


                return ask;
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
        }
    }
    abstract class Human
    {
        public string surname { get; set; }
        public int kurs { get; set; }
        public int recordBook { get; set; }

        public Human(string Surname, int Kurs, int RecordBook)
        {
            surname = Surname;
            kurs = Kurs;
            recordBook = RecordBook;
        }

        public virtual void Print() { Console.WriteLine($"Фамилия - {surname}, Курс - {kurs}, Номер зачетки - {recordBook} "); }
    }
    class Student : Human
    {

        public Student(string surname, int kurs, int recordBook) : base(surname, kurs, recordBook) { }

        public override void Print()
        {
            base.Print();
        }
        public override string ToString()
        {
            
            return string.Format("Фамилия - {0} Курс- {1} Номер зачетки - {2}", surname, kurs,recordBook);
        }
    }
    class Aspirant : Human
    {
        bool phdDefence { get; set; }

        public Aspirant(string surname, int kurs, int recordBook, bool phdDefence) : base(surname, kurs, recordBook)
        { this.phdDefence = phdDefence; }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"готовится к защите (аспирант)");
        }
        public override string ToString()
        {

            return string.Format("Фамилия - {0} Курс- {1} Номер зачетки - {2} готовится к защите (аспирант)", surname, kurs, recordBook);
        }
    }
}
