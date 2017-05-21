using DataContextLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {

            using (LinqModel db = new LinqModel())
            {
                //extension method group by
                var phones = db.Phones.GroupBy(p => p.Company.Name);
                foreach (var p in phones)
                {
                    Console.WriteLine(p.Key + p.Count());
                    foreach (var g in p)
                    {
                        Console.WriteLine(g.Id + " " + g.Name + " " + g.Price + " " + g.Company);
                    }
                }


                //linq 
                var phonesLinq = from phone in db.Phones
                                  group phone by phone.Company.Name;
                foreach (var p in phonesLinq)
                {
                    Console.WriteLine(p.Key + p.Count());
                    foreach (var g in p)
                    {
                        Console.WriteLine(g.Id + " " + g.Name + " " + g.Price + " " + g.Company);
                    }
                }

            }
        }
    }
}
