using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncitonalProgramming.Models
{
    public class HigherOrderFunctions
    {   
        // The Map function takes a sequence and a function as input and applies
        // the function to each element of the sequence. The output of the function
        // is a new sequence with the same number of elements.
        public static List<TOut> Map<TIn, TOut>(List<TIn> list, Func<TIn, TOut> mapper)
        {
            var result= new List<TOut>();
            foreach (var item in list)
            {
                result.Add(mapper(item));
            }
            return result;
        }

        //The Filter function takes a sequence and a predicate function as input and
        //returns a new sequence containing only the elements that satisfy the predicate.
        public static List<T> Filter<T>(List<T> list, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        // This method will demonstrate Map and Filter functions using List<Book>
        public static void DemonstrateHOF() {

            var books = Book.DeserializeBooks(); // loading all books from file

            // this lambda will set price for every using Map function
            Func<Book, Book> setPrice = x =>
            {
                x.Price = Math.Round(new Random().NextDouble() * 100, 2);
                return x;
            };
            var booksWithMap = Map(books, setPrice);
            string firstOutput = string
                .Join(Environment.NewLine,
                booksWithMap.Select(x => $"Title: {x.Name}, Price: {x.Price}"));
            Console.WriteLine(firstOutput);

            Console.WriteLine("================================");

            Func<Book, bool> filterByPrice = book => book.Price > 50;

            var booksWithFilter = Filter(books, filterByPrice);
            string secondOutput = string
               .Join(Environment.NewLine, booksWithFilter
               .OrderBy(x => x.Price)
               .Select(x => $"Title: {x.Name}, Price: {x.Price}"));
            Console.WriteLine(secondOutput);
        }
    }
}
