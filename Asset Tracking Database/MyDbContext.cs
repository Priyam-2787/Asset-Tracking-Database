using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Tracking_Database
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Asset Tracking Database;Integrated Security=True";

        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Computer> Computers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We tell the app to use the ConnectionString.
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Computer>().HasData(new Computer { Id = 1, Brand = "HP", MdelName = "Elitebook", Price = 1423, Office = "Spain", Currency = "EUR" });
            ModelBuilder.Entity<Computer>().HasData(new Computer { Id = 2, Brand = "Asus", MdelName = "W234", Price = 1200, Office = "USA", Currency = "USD" });
            ModelBuilder.Entity<Computer>().HasData(new Computer { Id = 3, Brand = "HP", MdelName = "Elitebook", Price = 588, Office = "Sweden", Currency = "SEK" });
            ModelBuilder.Entity<Computer>().HasData(new Computer { Id = 4, Brand = "Lenovo", MdelName = "Yoga730", Price = 835, Office = "USA", Currency = "USD" });
            ModelBuilder.Entity<Computer>().HasData(new Computer { Id = 5, Brand = "Lenovo", MdelName = "Yoga432", Price = 745, Office = "USA", Currency = "USD" });


            ModelBuilder.Entity<Mobile>().HasData(new Mobile { Id = 1, Brand = "iphone", MdelName = "8", Price = 970, Office = "Spain", Currency = "EUR" });
            ModelBuilder.Entity<Mobile>().HasData(new Mobile { Id = 2, Brand = "iphone", MdelName = "11", Price = 990, Office = "Spain", Currency = "EUR" });
            ModelBuilder.Entity<Mobile>().HasData(new Mobile { Id = 3, Brand = "iphone", MdelName = "x", Price = 970, Office = "Sweden", Currency = "SEK" });
            ModelBuilder.Entity<Mobile>().HasData(new Mobile { Id = 4, Brand = "Motorola", MdelName = "Razer", Price = 970, Office = "Sweden", Currency = "SEK" });
            ModelBuilder.Entity<Mobile>().HasData(new Mobile { Id = 5, Brand = "Motorola", MdelName = "G", Price = 870, Office = "Sweden", Currency = "SEK" });


            ModelBuilder.Entity<Computer>()
                .HasMany(x => x.MobileList)
                .WithMany(x => x.ComputerList)
                .UsingEntity(x => x.HasData(new { ComputerListId = 1, MobileListId = 1 }));
        }
    }
}



    

