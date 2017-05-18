using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ManyToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ManyToManyDbEntity>());
           
            using (ManyToManyDbEntity db = new ManyToManyDbEntity())
            {
                Product p1 = new Product { Name = "Nokia Lumia 930", Price = 9000 };
                Product p2 = new Product { Name = "Nokia Lumia 830", Price = 6000 };
                Product p3 = new Product { Name = "Samsung Galaxy S5", Price = 10000 };
                Product p4 = new Product { Name = "Samsung Galaxy S4", Price = 6000 };

                db.Products.AddRange(new List<Product> { p1, p2, p3, p4 });
                db.SaveChanges();

                Order order1 = new Order { Customer = "Nazar", Quantity = 1 };
                order1.Product.Add(p1);
                order1.Product.Add(p2);
                order1.Product.Add(p4);

                Order order2 = new Order { Customer = "Alex", Quantity = 2 };
                order2.Product.Add(p1);
                order2.Product.Add(p3);
                order2.Product.Add(p4);

                db.Orders.AddRange(new List<Order> { order1, order2 });
                db.SaveChanges();

                foreach (var itemProd in db.Products.Include(p => p.Order))
                {
                    Console.WriteLine("{0}.{1}", itemProd.Id, itemProd.Name);

                    if (itemProd.Order == null) continue;

                    foreach (var itemOrder in itemProd.Order)
                    {
                        Console.WriteLine("{0}.{1}", itemOrder.Id, itemOrder.Customer);
                    }
                    Console.WriteLine("-----------------------------------------");
                }

                Console.WriteLine("-----------------------------------------");
                Console.ReadKey();

                foreach (var itemOrder in db.Orders.Include(p => p.Product))
                {
                    Console.WriteLine("{0}.{1}", itemOrder.Id, itemOrder.Customer);

                    if (itemOrder.Product == null) continue;

                    foreach (var itemProd in itemOrder.Product)
                    {
                        Console.WriteLine("{0}.{1} - {2}", itemProd.Id, itemProd.Name, itemProd.Price);
                    }
                    Console.WriteLine("-----------------------------------------");
                }
                Console.ReadKey();

            }
        }
    }
}
