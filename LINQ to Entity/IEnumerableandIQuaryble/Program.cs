using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContextLinq;
namespace IEnumerableandIQuaryble
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LinqModel db = new LinqModel())
            {
                IEnumerable<Phone> phones = db.Phones.ToList();
                phones = phones.Where(p => p.Id > 3);
                foreach (var item in phones)
                {
                    Console.WriteLine(item.Name);

                }
            }
        }
    }
}
