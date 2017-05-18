namespace OneToMany
{
    using System.Data.Entity;

    public class OneToMany : DbContext
    {

        public OneToMany()
            : base("name=OneToMany")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orderss { get; set; }
    }


}