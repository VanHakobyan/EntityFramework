using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Model context = new Model();
            context.Persons.Add(new Person { FirstName = "van", LastName = "hakobyan", Age = 21 });
            context.SaveChanges();
            var list = context.Persons.ToList(); 
            foreach (var pers in list)
            {
                Console.WriteLine($"{pers.ID}:{pers.FirstName} {pers.LastName} {pers.Age}");
            }
        }
    }
}
