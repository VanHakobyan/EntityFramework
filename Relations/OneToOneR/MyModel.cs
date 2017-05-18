namespace OneToOneR
{
    using System.Data.Entity;

    public class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }


        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }

}