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


        public DbSet<Brand> Brands
        {
            get;
            set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>(b =>
            {
                b.ToTable("Brands");
                b.Property(t => t.Id).ValueGeneratedNever();

                b.Property(t => t.Name).HasMaxLength(50);
                b.Property(t => t.PinYin).HasMaxLength(50);
                b.Property(t => t.FirstLetter).HasMaxLength(1);
            });
        }
    }
}
