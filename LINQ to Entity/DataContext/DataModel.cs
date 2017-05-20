namespace DataContext
{
    using System.Data.Entity;

    public class DataModel : DbContext
    {
        //DbSet представляет коллекцию всех сущностей указанного типа, которые содержатся в 
        //контексте или могут быть запрошены из базы данных.

        static DataModel()
        {
            Database.SetInitializer(new MyContextInitializer());
        }
        public DataModel()
            : base("name=DataModel")
        {
        }
        
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }

    }
}