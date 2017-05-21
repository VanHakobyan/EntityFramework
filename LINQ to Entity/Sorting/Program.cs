using DataContextLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LinqModel db = new LinqModel())
            {
                //first version 
                var phone = db.Phones.OrderBy(p => p.Name);
                foreach (var p in phone)
                {
                    Console.WriteLine(p.Name + " " + p.Company + " " + p.Price);
                }

                //other version in linq
                var phone2 = from p in db.Phones
                             orderby p.Name
                             select p;
                foreach (var p in phone2)
                {
                    Console.WriteLine(p.Name + " " + p.Company + " " + p.Price);
                }
                //Descending
                var phoneDec = db.Phones.OrderByDescending(p => p.Name);
                foreach (var p in phoneDec)
                {
                    Console.WriteLine(p.Name + " " + p.Company + " " + p.Price);
                }

                //ThenBy LINQ
                var phone3 = db.Phones.Select(p => new { p.Name, Company = p.Company.Name, p.Price })
                    .OrderBy(p => p.Price)
                    .ThenBy(p => p.Company);
                foreach (var p in phone3)
                {
                    Console.WriteLine(p.Name + " " + p.Company + " " + p.Price);
                }





            }

        }
    }
}
