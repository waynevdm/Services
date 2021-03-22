using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TheRoom.Services.Domain;

namespace TheRoom.Services.Data
{
    public class ServiceContext : DbContext
    {
        public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLExpress;Initial Catalog=Services;Trusted_Connection=Yes;"); // Should use a connection string and not SQL Express
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(new Service
            {
                ServiceID = 1,
                Description = "Sitecostructor.io",
                PromoCode = "itpromocodes"
            }, new Service
            {
                ServiceID = 2,
                Description = "AppVision.com",
                PromoCode = "itpromocodes"
            }, new Service
            {
                ServiceID = 3,
                Description = "Analytics.com",
                PromoCode = "itpromocodes"
            }, new Service
            {
                ServiceID = 4,
                Description = "Logotype",
                PromoCode = "itpromocodes"
            }
            );
        }
    }
}
