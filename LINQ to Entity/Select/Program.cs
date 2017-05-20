using DataContextLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LinqModel db = new LinqModel())
            {
                var ph = db.Phones.Where(p => p.Name.Contains("Nokia"));
                foreach (var item in ph)
                {
                    Console.WriteLine(item.Name + " " + item.Price + " " + item.Company + " " + item.Id);
                }


                var phone = db.Phones.Find(3);
                Console.WriteLine(phone.Id + " " + phone.Name + " " + phone.Price);

                var phone1 = db.Phones.FirstOrDefault(p => p.Id == 4);
                if (phone1 != null)
                {
                    Console.WriteLine(phone1.Id + " " + phone1.Name + " " + phone1.Price);
                }


                var sel = db.Phones.Select(p => new {p.Id, p.Name, p.Price , Company =p.Company.Name});
                foreach (var item in sel)
                {
                    Console.WriteLine(item.Name + " " + item.Price + " " + item.Company + " " + item.Id);
                }
            }


        }
    }
}
