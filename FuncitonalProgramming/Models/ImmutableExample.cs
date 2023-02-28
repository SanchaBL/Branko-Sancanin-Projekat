using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncitonalProgramming.Models
{
    public class ImmutableExample
    {
        public Person Person { get; set; }

        public void ImmutableListExample()
        {
            // Create an immutable dictionary
            var immutableList = ImmutableList<string>.Empty;

            // Add items to the list
            immutableList = immutableList.Add("foo");
            immutableList = immutableList.Add("bar");
            immutableList = immutableList.Add("baz");

            // Get a new list with an item removed
            var newList = immutableList.Remove("bar");

            // The original list is still unchanged
            Console.WriteLine(string.Join(", ", immutableList)); // "foo, bar, baz"
            Console.WriteLine(string.Join(", ", newList));
        }

        public void ImmubaleDictionaryExample()
        {
            // Create an immutable dictionary
            var immutableDict = ImmutableDictionary<string, int>.Empty;

            // Add items to the dictionary
            immutableDict = immutableDict.Add("one", 1);
            immutableDict = immutableDict.Add("two", 2);
            immutableDict = immutableDict.Add("three", 3);

            // Get a new dictionary with an item removed
            var newDict = immutableDict.Remove("two");

            // The original dictionary is still unchanged
            Console.WriteLine(string.Join(", ", immutableDict)); // "one: 1, two: 2, three: 3"
            Console.WriteLine(string.Join(", ", newDict)); // "one: 1, three: 3"
        }

        public void PersonExample()
        {
            var person = new Person("John Doe", 30);
            Console.WriteLine($"Name: {person.GetName}, Age: {person.GetAge}"); // Output: Name: John Doe, Age: 30
        }
    }
}
