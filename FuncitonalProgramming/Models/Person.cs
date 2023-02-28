using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncitonalProgramming.Models
{
    public class Person
    {
        private readonly string Name;
        private readonly int Age;

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string GetName => Name;
        public int GetAge => Age;
    }
}
