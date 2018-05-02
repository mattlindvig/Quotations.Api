using Microsoft.EntityFrameworkCore;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EF
{
    public class DatabaseSetup : DbContext
    {
        public DatabaseSetup(DbContextOptions<DatabaseSetup> options) : base(options) { }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<User> User { get; set; }
    }
   
}
