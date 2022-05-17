using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Test_Mindbox_SQL.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Test_Mindbox;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());

            builder.Entity<Product>().HasQueryFilter(x => x.Price != 0);

            builder.Entity<Category>()
                .HasMany(x => x.Products)
                .WithMany(x => x.Categories)
                .UsingEntity(x =>
                {
                    x.ToTable("ProductsCategories");
                    x.Property<int>("CategoryId");
                    x.Property<int>("ProductId");
                });
        }        
    }

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(30).IsRequired().HasDefaultValue("");
            builder.Property(x => x.Price).HasMaxLength(1000000).IsRequired().HasDefaultValue(0);
        }
    }

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(30).IsRequired().HasDefaultValue("");
        }
    }
}
