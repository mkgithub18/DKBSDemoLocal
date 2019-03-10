using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReposirotyPatternDemo
{
    public class DkbsContext : DbContext
    {
        public DkbsContext()
        {

        }
        public DkbsContext(DbContextOptions<DkbsContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Partner> Partners { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Below is to Seed data only
            modelBuilder.Entity<Customer>().HasData(new Customer() { CustomerId=100, Name="Hindustan Liver", OrderName= "Dettol" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { CustomerId = 101, Name = "Emami", OrderName = "Savlon" });
            modelBuilder.Entity<Customer>().HasData(new Customer() { CustomerId = 102, Name = "Boro Plus", OrderName = "Sheeter" });
            modelBuilder.Entity<Partner>().HasData(new Partner() { PartnerId = 200, PartnerName = "White feather", ZipCode = 482001 });
            modelBuilder.Entity<Partner>().HasData(new Partner() { PartnerId = 201, PartnerName = "Blak Panther", ZipCode = 144211 });
            modelBuilder.Entity<Partner>().HasData(new Partner() { PartnerId = 202, PartnerName = "Hinduja", ZipCode = 560076 });
        }
    }
}
