using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleOwnsOne
{
    public class PeopleDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PeopleOwnsOne;Integrated Security=True;");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().OwnsOne(p => p.Address).ToTable("Addresses");
            modelBuilder.Entity<Person>().OwnsOne(p => p.EmailAddress, o => o.Property(o => o.Address).HasColumnName("EmailAddress"));
        }
    }
}
