using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person{FirstName="Van",LastName="Hakobyan",Salary=100000,StartDate=DateTime.Parse("14-06-2017")},
                new Person{FirstName="Messi",LastName="Leo",Salary=20000000,StartDate=DateTime.Parse("14-06-2007")},
                new Person{FirstName="Jordi",LastName="Alba",Salary=1000000,StartDate=DateTime.Parse("14/06/2010")}
            };

            var query = Enumerable.Select(
                Enumerable.Where(
                    persons, p => p.Salary > 1000000),
                p => new { LastName = p.LastName, FirstName = p.FirstName, Salary = p.Salary, StaertDate = p.StartDate });
            var query1 = persons.
                Where(p => p.Salary > 1000000).
                Select(p => new { LastName = p.LastName, FirstName = p.FirstName, Salary = p.Salary, StaertDate = p.StartDate });

            var query2 = from person in persons
                         where person.Salary < 210000
                         select new { person.FirstName, person.LastName , person.Salary, person.StartDate };
            foreach (var item in query1)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Salary + " " + item.StaertDate);
            }
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
