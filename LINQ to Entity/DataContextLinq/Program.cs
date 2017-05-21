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
