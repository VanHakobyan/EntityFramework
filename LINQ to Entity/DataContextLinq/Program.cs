using System;
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

                var sel = db.Phones.Select(p => new { p.Id, p.Name, p.Price, Company = p.Company.Name });
                foreach (var item in sel)
                {
                    Console.WriteLine(item.Name + " " + item.Price + " " + item.Company + " " + item.Id);
                }
            }
        }
    }
}
