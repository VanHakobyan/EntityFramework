using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person{Name="Van",Age=21},
                new Person{Name="Messi",Age=28},
                new Person{Name="Alba",Age=26},
                new Person{Name="Sergi",Age=25}
            };
            var query = from person in persons
                        where person.Age > 24
                        select person.Name+" "+person.Age;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
