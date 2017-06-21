using System;
using AutohomeCralwer.EF.SQLServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutohomeCralwer.EF.SQLServer
{
    public class AutohomeDbContext : DbContext
    {
        public AutohomeDbContext(DbContextOptions<AutohomeDbContext> options) : base(options)
        {
        }


        public DbSet<Brand> Brands { get; set; }

        public DbSet<Factory> Factories { get; set; }

        public DbSet<Serie> Series { get; set; }

        public DbSet<Year> Years { get; set; }

        public DbSet<CarType> CarTypes { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<InnerColor> InnerColors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>(b =>
            {
                b.ToTable(TableNames.Brands);
                b.Property(t => t.Id).ValueGeneratedNever();

                b.Property(t => t.Name).HasMaxLength(50);
                b.Property(t => t.PinYin).HasMaxLength(50);
                b.Property(t => t.FirstLetter).HasMaxLength(1);
            });

            modelBuilder.Entity<Factory>(b =>
            {
                b.ToTable(TableNames.Factories);
                b.Property(t => t.Id).ValueGeneratedNever();


            });
        }
    }
}
