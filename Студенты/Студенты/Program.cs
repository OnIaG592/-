using System;

namespace Студенты
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string surname = "";
            int kurs = 0;
            int recordBook = 0;
            int studentCounter = 0;
            int aspirantCounter = 0;
            bool phdDefence = true;
            int size = 0;
            int size1 = 0;
            int studentNumber = 0;
            int aspirantNumber = 0;
            int studentIndex = 0;
            int aspirantIndex = 0;
            MyArray arr = new MyArray();
            MyArray1 arr1 = new MyArray1();
            MyArray newArr = new MyArray();
            MyArray1 newArr1 = new MyArray1();
            do
            {

                
                Console.WriteLine("1)Добавить Студента\n2)Добавить Аспиранта\n3)Вывести количество студентов\n4)Вывести количество аспирантов\n5)Вывести список всех студентов\n6)Вывести список всех аспирантов\n7)Вывести студента по порядковому индексу\n8)Вывести аспиранта по порядковому индексу\n9)Удаление студента по порядковому индексу\n10)Удаление аспиранта по порядковому индексу\n11)Выход из приложения");
               string answer = Console.ReadLine();
                size = studentCounter + 1;
                size1= aspirantCounter +1;
               
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Введите фамилию студента:");
                        surname = AskSurname();
                        Console.WriteLine("Введите на каком курсе студент:");
                        kurs = AskNum();
                        Console.WriteLine("Введите номер Зачетки студента:");
                        recordBook = AskNum();
                        arr[size] = new Student(surname, kurs, recordBook);
                        studentCounter++;
                        break;
                    case "2":
                       
                        Console.WriteLine("Введите фамилию Аспиранта:");
                        surname = AskSurname();
                        Console.WriteLine("Введите на каком курсе аспирант:");
                        kurs = AskNum();
                        Console.WriteLine("Введите номер Зачетки аспиранта:");
                        recordBook = AskNum();
                        arr1[size1] = new Aspirant(surname, kurs, recordBook,phdDefence);
                        aspirantCounter++;
                        break;
                    case "3":
                        Console.WriteLine($"Учатся {studentCounter} студент (а).");
                        break;
                    case "4":
                        Console.WriteLine($"Учатся {aspirantCounter} аспирант (а).");
                        break;
                    case "5":
                        if (studentCounter==0)
                        {
                            Console.WriteLine("Студентов нет");
                        }
                        for (int i = 1; i < size; i++)
                        {
                            arr[i].Print();
                        }
                        break;
                    case "6":
                        if (aspirantCounter == 0)
                        {
                            Console.WriteLine("Аспирантов нет");
                        }
                        for (int i = 1; i < size1; i++)
                        {
                            arr1[i].Print();
                        }
                        break;
                    case "7":
                        Console.WriteLine("Введите порядковый номер студента");
                        studentNumber = AskNum();
                        if (studentNumber>0 && studentNumber<size)
                        {
                            arr[studentNumber].Print();
                        }
                        else { Console.WriteLine("Студента под таким порядковым номером не существует!"); }
                        break;
                    case "8":
                        Console.WriteLine("Введите порядковый номер аспиранта");
                        aspirantNumber = AskNum();
                        if (aspirantNumber > 0 && aspirantNumber < size1)
                        {
                            arr1[aspirantNumber].Print();
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
                            for (int i = 0; i < studentIndex; i++)
                            {
                                newArr[i] = arr[i];
                            }
                            for (int i = studentIndex + 1; i < size; i++)
                            {
                                newArr[i - 1] = arr[i];
                            }
                            arr = newArr;
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
                            for (int i = 0; i < aspirantIndex; i++)
                            {
                                newArr1[i] = arr1[i];
                            }
                            for (int i = aspirantIndex + 1; i < size1; i++)
                            {
                                newArr1[i - 1] = arr1[i];
                            }
                            arr1 = newArr1;
                            size1= size1 - 1;
                            aspirantCounter = aspirantCounter - 1;
                        }
                        break;
                    case "11":
                        Console.WriteLine("Выход");exit = true;
                        break;
                    default:
                        Console.WriteLine("Вы можете ввести цифру от 1 до 11");
                        break;
                } 
            } while (exit == false);
            Console.ReadKey();
        }
        static string AskSurname()
        {
            
            bool b = false;
            string c = " ";
            do
            {
                try
                {
                    c = Console.ReadLine();
                    foreach (var item in c)
                    {
                        int temp = item.GetHashCode();
                        if (item >= '0' && item <= '9' || item == '\x20')
                        {
                            Console.WriteLine("Не правильный ввод;\nВведите заново");
                            b = false;
                            break;
                        }
                        else { b = true; }

                    }
                }
                catch
                {
                    Console.WriteLine("Не правильный ввод;\nВведите заново");

                }
            } while (b == false);


            return c;
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
    }
    class Student
    {
        private string surname { get; set; }
        private int kurs { get; set; }
        private int recordBook { get; set; }

        public Student (string Surname,int Kurs,int RecordBook)
        {
            surname = Surname;
            kurs = Kurs;
            recordBook = RecordBook;
        }

        public virtual void Print() { Console.WriteLine($"Фамилия - {surname}, Курс - {kurs}, Номер зачетки - {recordBook} "); }
        

    }
    class Aspirant : Student
    {
        bool phdDefence { get; set; }

        public Aspirant(string surname,int kurs,int recordBook,bool phdDefence) : base(surname,kurs,recordBook)
        { this.phdDefence = phdDefence;}
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"готовится к защите (аспирант)");
    }
}


class MyArray
{
    Student[] data;
    public MyArray()
    {
        data = new Student[100];
    }
    public Student this[int index]
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

class MyArray1
{
    Aspirant[] data;
    public MyArray1()
    {
        data = new Aspirant[100];
    }
    public Aspirant this[int index]
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





