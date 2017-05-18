using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OneToMany>());

            using (OneToMany db = new OneToMany())
            {
                var p1 = new Product { Name = "C#", Price = 7 };
                var p2 = new Product { Name = "F#", Price = 3 };
                var p3 = new Product { Name = "Java", Price = 6 };
                var p4 = new Product { Name = "SQL", Price = 16 };
                var p5 = new Product { Name = "ASP.NET", Price = 6 };
                db.Products.AddRange(new List<Product> { p1, p2, p3, p4, p5 });
                db.SaveChanges();
                var products = db.Products.ToList();
                foreach (var item in products)
                {
                    Console.WriteLine("{0}: {1} {2} {3}", item.ID, item.Name, item.Price, item.Order != null ? item.Order.Customer : "no Cunsumer");
                }
                Console.WriteLine(new string('-',50));
                Console.ReadKey();
                Order o1 = new Order { Customer = "Mic", Quantity = 5, Product = new List<Product>() { p1, p5 } };
                Order o2 = new Order { Customer = "Apple", Quantity = 3, Product = new List<Product> { p3, p4 } };

                db.Orderss.AddRange(new List<Order> { o1, o2 });
                db.SaveChanges();

                var products1 = db.Products.ToList();

                foreach (var item in products)
                {
                    Console.WriteLine("{0}: {1} {2} {3}", item.ID, item.Name, item.Price, item.Order != null ? item.Order.Customer : "no Cunsumer");
                }
                Console.WriteLine(new string('-', 50));
                Console.ReadKey();
                var orders = db.Orderss.ToList();
                foreach (var itemOrder in orders)
                {
                    Console.WriteLine($"{itemOrder.Customer},{itemOrder.Product}");
                    if (itemOrder.Product == null) continue;
                    foreach (var itemProd in itemOrder.Product)
                    {
                        Console.WriteLine("{0}: {1} {2} {3}", itemProd.Name, itemProd.Price,itemOrder.Quantity,itemProd.Price* itemOrder.Quantity);
                    }
                    Console.WriteLine(new string('-', 50));

                }
                Console.ReadKey();
            }

        }
    }
}
