using System;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = {
"Второе предубеждение, стоящее за установкой, что в любви нечему учиться, – это допущение, что проблема любви есть проблема объекта, а не проблема способности.",
"Принято думать, что любить просто, а найти достойный объект для любви или для того, чтобы быть любимым, – вот это трудно.",
"Прежде всего сыграло роль резкое изменение отношения к выбору «объекта любви», происшедшее в XX столетии. В викторианскую эпоху, как и во многих культурах, приверженных традициям, любовь не была непосредственным личным переживанием, которое могло привести затем к браку.",
"Напротив, браки заключались по договору – или при посредничестве каких-либо почтенных семейств либо брачного маклера, или без посредников.",
"Они заключались из соображений, социальных по своей природе. Что же касается любви, то предполагалось, что она появится и будет крепнуть после заключения брака. Однако за время жизни нескольких последних поколений в западном мире почти окончательно восторжествовала концепция романтической любви."

    };
            string a = array[0];
            string b = array[1];
            string c = array[2];
            string d = array[3];
            string e = array[4];

            if (a.Length > b.Length && a.Length > c.Length && a.Length > d.Length && a.Length > e.Length) { Console.WriteLine($"{a}- Эта строка самая длинная , количество символов {a.Length-1}"); }
            if (b.Length > a.Length && b.Length > c.Length && b.Length > d.Length && b.Length > e.Length) { Console.WriteLine($"{b}- Эта строка самая длинная, количество символов {b.Length - 1}"); }
            if (c.Length > a.Length && c.Length > b.Length && c.Length > d.Length && c.Length > e.Length) { Console.WriteLine($"{c}- Эта строка самая длинная , количество символов {c.Length - 1}"); }
            if (d.Length > a.Length && d.Length > b.Length && d.Length > c.Length && d.Length > e.Length) { Console.WriteLine($"{d}- Эта строка самая длинная , количество символов {d.Length - 1}"); }
            if (e.Length > a.Length && e.Length > b.Length && e.Length > c.Length && e.Length > d.Length) { Console.WriteLine($"{e}- Эта строка самая длинная , количество символов {e.Length - 1}"); }

            if (a.Length < b.Length && a.Length < c.Length && a.Length < d.Length && a.Length < e.Length) { Console.WriteLine($"{a}- Эта строка самая короткая, количество символов {a.Length - 1}"); }
            if (b.Length < a.Length && b.Length < c.Length && b.Length < d.Length && b.Length < e.Length) { Console.WriteLine($"{b}- Эта строка самая короткая, количество символов {b.Length - 1}"); }
            if (c.Length < a.Length && c.Length < b.Length && c.Length < d.Length && c.Length < e.Length) { Console.WriteLine($"{c}- Эта строка самая короткая , количество символов {c.Length - 1}"); }
            if (d.Length < a.Length && d.Length < b.Length && d.Length < c.Length && d.Length < e.Length) { Console.WriteLine($"{d}- Эта строка самая короткая , количество символов {d.Length - 1}"); }
            if (e.Length < a.Length && e.Length < b.Length && e.Length < c.Length && e.Length < d.Length) { Console.WriteLine($"{e}- Эта строка самая короткая , количество символов {e.Length - 1}"); }

            Console.ReadKey();
        }
    }
}
