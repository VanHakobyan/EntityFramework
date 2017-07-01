using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitilizationDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<CodeContext>());
            using (CodeContext db = new CodeContext())
            {
                db.Phones.Add(new Phone { Name = "Samsung A1", Price = 200000 });
                db.Phones.Add(new Phone { Name = "Samsung J1", Price = 300000 });
                db.Phones.Add(new Phone { Name = "Samsung J6", Price = 400000 });
                db.Phones.Add(new Phone { Name = "Samsung Gio", Price = 100000 });
                db.SaveChanges();
                var phones = db.Phones.ToList();
                foreach (var phone in phones)
                {
                    Console.WriteLine(phone.Name+" "+phone.Price);
                }
            }
        }
    }
}
