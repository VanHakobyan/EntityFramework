using System.Data.Entity;

namespace ManyToMany
{
    public class ManyToManyDbEntity : DbContext
    {
        public ManyToManyDbEntity()
            : base("name=ManyToManyDbEntity")
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}