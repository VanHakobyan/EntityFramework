﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LinqModel db = new LinqModel())
            {

                //Linq inner join
                var phonesJoinLinq = from phone in db.Phones
                                     join comp in db.Companies on phone.CompanyId equals comp.Id
                                     select new
                                     {
                                         phone.Id,
                                         phone.Name,
                                         Company = comp.Name,
                                         phone.Price
                                     };
                foreach (var p in phonesJoinLinq )
                {
                    Console.WriteLine($"{p.Id}: {p.Name} {p.Company} {p.Price}");
                }


            }
        }
    }
}
