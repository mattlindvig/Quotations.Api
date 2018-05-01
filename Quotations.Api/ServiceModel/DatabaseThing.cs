using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceModel
{
    public class DatabaseThing : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-K3IJTVP\SQLEXPRESS;Database=Quotations;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
   
}
