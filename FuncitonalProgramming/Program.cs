// See https://aka.ms/new-console-template for more information
using FuncitonalProgramming.Models;

List<Book> books = Book.DeserializeBooks(); // I loaded few  books from Books.json file
/*
   Two ways to demonstrate LINQ or Language integrated query
 */

// First filter are books that were published in first decate of twenty first century 

var firstFilter = books
     .Where(x => x.YearOfPublication > 2000 && x.YearOfPublication < 2010)
     .OrderBy(x => x.Writer)
     .ToList();

// Secpnd filter are books written by Paulo Coelho ordered by year of publication
var secondFilter = books
    .Where(x => x.Writer.Contains("Paulo Coelho"))
    .OrderBy(x => x.YearOfPublication)
    .ToList();

// Same filter as last one just written as Sql query, also books are ordered by Title or Name 
var thirdFilter = from book in books
                  where book.Writer.Contains("Paulo Coelho")
                  orderby book.Name descending
                  select book;

string output = string
    .Join(Environment.NewLine,
    firstFilter.Select(x => $"Title: {x.Name}, Writer: {x.Writer}, Year: {x.YearOfPublication}"));

Console.WriteLine(output);
/*
 * Examples for immutable types, there are few that are already defined in C# and also one example that
 * I defined
 */
Console.WriteLine("================================");

var immutableExample = new ImmutableExample();
immutableExample.ImmubaleDictionaryExample();
immutableExample.ImmutableListExample();
immutableExample.PersonExample();

Console.WriteLine("================================");

HigherOrderFunctions.DemonstrateHOF();

// Using ternary operators instead of if/else statements
/*
 // declaration
int age;
if (user != null)
{
    age = user.Age;
}
else
{
    age = 0;
}

// expression
int age = (user != null) ? user.Age : 0;*/
// Using LINQ expressions instead of loops
// declaration
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<int> evenNumbers = new List<int>();
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
}

// expression
/* List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList(); */