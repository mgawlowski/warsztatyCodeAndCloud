using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Warsztaty.Core
{
    class DataContext : DbContext
    {
        public virtual DbSet<ContactModel> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:warsztatydb2018.database.windows.net,1433;Initial Catalog=warsztatyDB;Persist Security Info=False;User ID=xentix;Password=Wdupie12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
