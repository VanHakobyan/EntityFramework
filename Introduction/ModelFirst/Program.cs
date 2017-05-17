using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main()
        {
            using (PersonalModelContainer dbContainer = new PersonalModelContainer())
            {
                dbContainer.Pesons.Add(new Pesons { Id = 1, FirstName = "VAn", LastName = "Hakobyan", Age = 21 });
                dbContainer.Pesons.Add(new Pesons { Id = 2, FirstName = "Lil", LastName = "Hakobyan", Age = 23 });
                dbContainer.SaveChanges();

                var list = dbContainer.Pesons.ToArray();
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName} {item.Age}");
                }
            }
        }
    }
}
