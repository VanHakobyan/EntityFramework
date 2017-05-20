namespace DataContextLinq
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LinqModel : DbContext
    {
        
        public LinqModel()
            : base("name=LinqModel")
        {
        }

        static LinqModel()
        {
            Database.SetInitializer(new MyContextInitializer());
        }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
    }

   
}