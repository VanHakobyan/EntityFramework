using System.Data.Entity;

namespace InitilizationDB
{
    public class CodeContext : DbContext
    {
        public CodeContext() :
            base("name=CodeContext")
        {
        }

        public virtual DbSet<Phone> Phones { get; set; }

    }
}
