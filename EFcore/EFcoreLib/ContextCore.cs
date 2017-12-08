using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFcoreLib
{
    public class ContextCore : DbContext
    {
        public DbSet<SimpleModel> SimpleModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=newDb;Trusted_Connection=True;");
        }
    }
}
