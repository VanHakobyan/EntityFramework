namespace CodeSecond
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelSecondConn")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

    }
}
