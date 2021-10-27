using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Principal;

namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Book book1 = new Book("Task pour les nuls", "Eliottness",
                Difficulty.EXTREME, 300, "lisez la doc et testez votre code!");
            Book book2 = new Book("Qu'est ce qu'un shell ?", "Leiyks",
                Difficulty.EXTREME, 1200, "Lisez la SCL!");
            Book book3 = new Book("How to survive Ing1", "Leiyks",
                Difficulty.EASY, 200, "Write efficient Testsuite :)");
            
            Book book4 = new Book("book4", "Eliottness",
                Difficulty.EXTREME, 300, "lisez la doc et testez votre code!");
            Book book5 = new Book("book5", "Leiyks",
                Difficulty.EXTREME, 1200, "Lisez la SCL!");
            Book book6 = new Book("book6", "Leiyks",
                Difficulty.EASY, 200, "Write efficient Testsuite :)");
            
            List<Book> books = new List<Book> { book1, book2, book3 };
            List<Book> books2 = new List<Book> { book4, book5, book6 };

            LevelTwo.PairReading(books,books2);*/

            Console.WriteLine("Usual Prime:");
            Stopwatch test = new Stopwatch();
            test.Start();
            List<int> bb = LevelThree.UsualPrimesGenerator(300000);
            test.Stop();
            TimeSpan ts = test.Elapsed;
            string time = String.Format("{0:00}:{1:00}",ts.Seconds,ts.Milliseconds);
            Console.WriteLine("RunTime : " + time);
            Console.WriteLine();
            
            Console.WriteLine("Magic Prime:");
            Stopwatch res = new Stopwatch();
            res.Start();
            List<int> lol = LevelThree.MagicPrimesGenerator(300000,32);
            res.Stop();
            TimeSpan gg = res.Elapsed;
            string bg = String.Format("{0:00}:{1:00}",gg.Seconds,gg.Milliseconds);
            Console.WriteLine("RunTime : " + bg);
            Console.WriteLine();
            Console.WriteLine("Usual Prime Elements :" + bb.Count);
            Console.WriteLine();
            Console.WriteLine("Magic Prime Elements :" + lol.Count);

        }
    }
}