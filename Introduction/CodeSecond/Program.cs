using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Model context = new Model())
            {
                context.Tables.Add(new Table { FirstName = "Leo", LastName = "Messi", Age = 30 });
                context.SaveChanges();
                var list = context.Tables.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Id}:{item.FirstName} {item.LastName} {item.Age}");
                }
            }
        }
    }
}
