using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Library
{
    public class LevelOne
    {
        /// <summary>
        ///     Remove all negatives values from the list
        /// </summary>
        public static void FilterNegative(List<int> list)
        {
            list.RemoveAll((int x) => x < 0);
        }

        /// <summary>
        ///     Return same as string.ToUpper() but in a List of char
        /// </summary>
        public static List<char> ToUpper(List<char> characters)
        {
            return (characters.ConvertAll(c => c >= 'a' && c <= 'z' ? (char) (c -32) : c));
        }

        /// <summary>
        ///     Use the function book.ToString() to print the list of books
        /// </summary>
        public static void PrintBooks(List<Book> books)
        {
            books.ForEach(book => Console.WriteLine(book.ToString()));
        }

        /// <summary>
        ///     Returns a list of books whose author is the one we want
        /// </summary>
        public static List<Book> FindAuthorBooks(List<Book> books, string author)
        {
            return new List<Book>(books.RemoveAll((Book book) => book.Summary.GetAuthor() != author));
        }

        /// <summary>
        ///     Return the maximum number of pages a book has in the list
        /// </summary>
        public static int GetLongestBookPages(List<Book> books)
        {
            return books.Max(x => x.Summary.GetPages());
        }

        /// <summary>
        ///     Return the number of books which content is containing the substring in parameters
        /// </summary>
        public static int FindOccurences(List<Book> books, string substring)
        {
            books.RemoveAll((Book book) => !book.Content.Contains(substring));
            return books.Count;
        }
    }
}