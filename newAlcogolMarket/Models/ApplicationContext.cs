﻿using newAlcogolMarket.Models.Entities;

namespace newAlcogolMarket.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Country> Сountries { get; set; }  
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ShopItems> Basket { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Snack> Snacks  { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {}
    }
}
