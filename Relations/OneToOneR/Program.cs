using System;
using System.Data.Entity;
using System.Linq;
namespace OneToOneR
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MyModel>());

            using (MyModel db = new MyModel())
            {
                Product p1 = new Product { Name = "Pepsi", Price = 350 };
                Product p2 = new Product { Name = "Fanta", Price = 340 };


                db.Products.Add(p1);
                db.Products.Add(p2);

                db.SaveChanges();

                Order o1 = new Order { Customer = "Van", Quantity = 5, Product = p2 };
                Order o2 = new Order { Customer = "Vanik", Quantity = 4, Product = p1 };
                db.Orders.Add(o1);
                db.Orders.Add(o2);

                db.SaveChanges();

                var orders = db.Orders.ToList();
                var product = db.Products.ToList();
                foreach (var item in orders)
                {
                    Console.WriteLine("{0}.{1}->({2}): price {3}$ - {4}H ",
                        item.Id,
                        item.Customer,
                        item.Product != null ? item.Product.Name : "x",
                        item.Product != null ? Convert.ToString(item.Product.Price) : "X",
                        item.Quantity);
                }
            }

        }
    }
}
