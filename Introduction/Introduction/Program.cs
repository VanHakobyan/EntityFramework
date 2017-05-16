using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseIntroEntities contextEntitys = new DataBaseIntroEntities();
            List<Table> list = contextEntitys.Tables.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName} {item.Age} ");
            }
        }
    }
}
